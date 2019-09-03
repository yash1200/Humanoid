import bluetooth
import threading

class Server:
    def __init__(self):
        self.sock=bluetooth.BluetoothSocket( bluetooth.RFCOMM )
        self.sock.bind(("",1))
        self.sock.listen(1)

    def run_server(self):
        print('started')
        while True:
            print('running')
            c,a=self.sock.accept()
            cThread=threading.Thread(target=self.handler,args=(c,a))
            cThread.deamon=True
            cThread.start()
            print(str(a[0])+':'+str(a[1])+'connected')

    def handler(self,c,a):
        try:
            while True:
                data=c.recv(1024)
                print(data)
                c.send('msg recieved')
        except:
            self.disconnect(c,a)

    def disconnect(self,c,a):
        c.close()

S = Server()
S.run_server()

