# coding=gbk
import sys, os
from collections import OrderedDict
import time
import threading
from lpmslib import LpmsME

def get_stream_data():
    sensor_data = lpmsSensor.get_stream_data()
    pretty_print_sensor_data(sensor_data)

def pretty_print_sensor_data(sensor_data):                      
    j = 25
    d = '.'
    print "IMU ID:".ljust(j, d), sensor_data[0]
    print "TimeStamp:".ljust(j, d), sensor_data[1]
    print "Frame Counter:".ljust(j, d), sensor_data[2]
    print "Temperature:".ljust(j, d), sensor_data[3]
    print "Acc:".ljust(j, d), ['%+.3f' % f for f in sensor_data[4]]
    print "Gyr:".ljust(j, d), ['%+.3f' % f for f in sensor_data[5]]
    print "Mag:".ljust(j, d), ['%+.3f' % f for f in sensor_data[6]]
    print "Quat:".ljust(j, d), ['%+.3f' % f for f in sensor_data[7]]
    print "Euler:".ljust(j, d), ['%+.3f' % f for f in sensor_data[8]]
    print "LinAcc:".ljust(j, d), ['%+.3f' % f for f in sensor_data[9]]

#连接 
def connect_sensor():                                                    
    print "Connecting sensor"
    if lpmsSensor.connect():
        print "Connected"
        get_config_register()

#读取信息
def get_config_register():                                      
    config_reg = lpmsSensor.get_config_register()
    print config_reg

#断开
def disconnect_sensor():                                        
    print "Disconnecting sensor"
    lpmsSensor.disconnect()
    print "Disconnected"

printer_running = False
stop_printing = True

#接数据
def print_data():                                                    
    thread = threading.Thread(target=printer, args=())
    global stop_printing
    stop_printing = False
    thread.start()

#停止
def stop_print_data():                                          
    global stop_printing
    global thread
    stop_printing = True
    if printer_running and thread.isAlive():
        thread.join()

#中断处理
def printer():                                                  
    global stop_printing
    global printer_running
    global printer_running
    printer_running = True
    while not stop_printing:
        os.system('cls')
        get_stream_data()
        time.sleep(.05)
    printer_running = False

thread = threading.Thread(target=printer, args=())
                          

port = 'COM5'
baudrate = 115200

lpmsSensor = LpmsME.LpmsME(port, baudrate)
quit = False

def main():
    global quit
    while not quit:
        choice = raw_input(" o:open c:close p:print e:exit>>  ")
        if(choice == 'o'):
            connect_sensor()
            choice =''
        if(choice == 'p'):
            if (lpmsSensor.is_sensor_connected == True):
                print_data()
        if(choice == 'c'):
            if (lpmsSensor.is_sensor_connected == True):
                disconnect_sensor()
            choice =''
        if(choice == ''):
            stop_print_data()
        if(choice == 'e'):
            quit=True
            

    disconnect_sensor()

if __name__ == "__main__":
    # Launch main menu
    main()
