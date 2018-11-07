# coding:utf-8
from collections import OrderedDict
import time
import threading
from lpmslib import LpmsME


class imu_driver():
    def __init__(self,inputport):
        '''
        todo: 初始化一些配置 创建类后自动会执行这个_init_
        '''
        self.port = inputport
        self.baudrate = 115200
        self.lpmsSensor = LpmsME.LpmsME(self.port, self.baudrate)
        self.lpmsSensor.connect()
        self.spin()
        
    def spin(self):
        '''
        todo: 循环读取(get_data) 并发布(pub) imu数据
        '''
        self.get_data()
        self.pub()

    def disconnect(self):
        self.lpmsSensor.disconnect()
        
    def get_data(self):
        '''
        todo: 接收数据 如acc等
        '''
        sensor_data = self.lpmsSensor.get_stream_data()
        self.imu_id=sensor_data[0]
        self.timestamp=sensor_data[1]
        self.framecounter=sensor_data[2]
        self.temperature=sensor_data[3]
        self.acc=sensor_data[4]
        self.gyr=sensor_data[5]
        self.mag=sensor_data[6]
        self.quat=sensor_data[7]
        self.euler=sensor_data[8]
        self.linacc=sensor_data[9]

    def pub(self):
        '''
        todo: 发布imu数据到ros,我来写
        '''
        print self.gyr
        self.disconnect()

if __name__ == '__main__':
    my_driver = imu_driver()
