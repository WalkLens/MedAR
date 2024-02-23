import socket
import traceback
import logging

def handle_string_data(string_data):
    # 문자열 데이터를 처리하는 함수
    # 예시로, 받은 데이터를 그대로 반환합니다.
    return string_data[::-1]  # 문자열을 뒤집어 반환합니다.

def sending_and_receiving():
    s = socket.socket()
    socket.setdefaulttimeout(None)
    print('Socket created')
    port = 60000
    s.bind(('127.0.0.1', port))  # local host
    s.listen(5)  # listening for connection
    print('Socket listening...')
    while True:
        try:
            c, addr = s.accept()  # when port connected
            print(f"Connection from {addr}")
            bytes_received = c.recv(4096)  # received bytes
            
            # 문자열 데이터를 UTF-8로 디코딩
            string_received = bytes_received.decode('utf-8')

            # 문자열 데이터 처리
            string_to_send_back = handle_string_data(string_received)

            # 처리된 문자열 데이터를 UTF-8로 인코딩하여 바이트로 변환
            bytes_to_send = string_to_send_back.encode('utf-8')
            
            # 변환된 바이트 데이터 전송
            c.sendall(bytes_to_send)
            
            c.close()
        except Exception as e:
            logging.error(traceback.format_exc())
            print("Error:", e)
            # 에러 발생시 빈 바이트 배열을 클라이언트에게 보내고 연결 종료
            c.sendall(bytearray([]))
            c.close()
            break

sending_and_receiving()    