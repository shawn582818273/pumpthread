using System;
using System.Collections.Generic;
using System.Threading;
namespace pumpthread
{
    class Program
    {
        public static int stimer1 = 0, stimer2 = 0, stimer3 = 0, stimer4 = 0, stimer5 = 0, stimer6 = 0;
        //public static List<ModbusTcpNet> busTcpClient = new List<ModbusTcpNet>();
        public static List<string> pumpIP = new List<string>();
        //public static SQLRelated sr = new SQLRelated();
        //public static MySqlConnection mycon;
        public static string ss1, ss2, ss3, ss4, ss5, ss6;
        public static List<short[]> int6_1 = new List<short[]>();
        public static List<short[]> int6_2 = new List<short[]>();
        public static List<short[]> int6_3 = new List<short[]>();
        public static List<short[]> int6_4 = new List<short[]>();
        public static List<short[]> int6_5 = new List<short[]>();
        public static List<short[]> int6_6 = new List<short[]>();
        public static void Main(string[] args)
        {
            /*
            mycon = sr.MysqlConnect("localhost", "root", "123456", "test");
            string temp = "129.0.1.";
            for (int i = 25; i < 61; i++)
            {
                pumpIP.Add((temp + i.ToString()));
            }
            for (int i = 0; i < 36; i++)
            {
                busTcpClient.Add(new ModbusTcpNet(pumpIP[i], 502, (byte)(i + 1)));   // 站号1 
                busTcpClient[i].AddressStartWithZero = false;
            }
            busTcpClient[0] = new ModbusTcpNet(pumpIP[0], 502, 0);
            busTcpClient[1] = new ModbusTcpNet(pumpIP[1], 502, 0);
            busTcpClient[18] = new ModbusTcpNet(pumpIP[18], 502, 0);
            busTcpClient[19] = new ModbusTcpNet(pumpIP[19], 502, 0);
            busTcpClient[0].AddressStartWithZero = false;
            busTcpClient[1].AddressStartWithZero = false;
            busTcpClient[18].AddressStartWithZero = false;
            busTcpClient[19].AddressStartWithZero = false;

            for (int i = 0; i < 6; i++)
            {
                int6_1.Add(new short[9]);
                int6_2.Add(new short[9]);
                int6_3.Add(new short[9]);
                int6_4.Add(new short[9]);
                int6_5.Add(new short[9]);
                int6_6.Add(new short[9]);
            }
            */
            Console.WriteLine("Hello World!");
            Thread thread1 = new Thread(threadstart1);
            thread1.Start();
            Thread thread2 = new Thread(threadstart2);
            thread2.Start();
            Thread thread3 = new Thread(threadstart3);
            thread3.Start();
            Thread thread4 = new Thread(threadstart4);
            thread4.Start();
            Thread thread5 = new Thread(threadstart5);
            thread5.Start();
            Thread thread6 = new Thread(threadstart6);
            thread6.Start();
        }
        public static void threadstart1()
        {

            while(true)
            {
                try
                {
                    Console.WriteLine("this is  thread start 1------" + stimer1++);

                    for (int i = 0; i < 6; i++)
                    {

                        Console.WriteLine(i + "---------" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff"));
                        /*
                        if (i < 2)
                        {
                            HslCommunication.OperateResult<short> read3003 = busTcpClient[0].ReadInt16("3003");//DP1 Temper
                            if (read3003.IsSuccess)
                                int6_1[0][0] = read3003.Content;
                            HslCommunication.OperateResult<short> read3001 = busTcpClient[0].ReadInt16("3001");//DP1 Current
                            if (read3001.IsSuccess)
                                int6_1[0][1] = read3001.Content;
                            HslCommunication.OperateResult<short> read3002 = busTcpClient[0].ReadInt16("3002");//DP1 Overpressure
                            if (read3002.IsSuccess)
                                int6_1[0][2] = read3002.Content;
                            HslCommunication.OperateResult<short> read3023 = busTcpClient[0].ReadInt16("3023");//MB Current
                            if (read3023.IsSuccess)
                                int6_1[0][3] = read3023.Content;
                            HslCommunication.OperateResult<short> read3028 = busTcpClient[0].ReadInt16("3028");//MB frequency
                            if (read3028.IsSuccess)
                                int6_1[0][4] = read3028.Content;
                            HslCommunication.OperateResult<short> read3036 = busTcpClient[0].ReadInt16("3036");//N2flow
                            if (read3036.IsSuccess)
                                int6_1[0][5] = read3036.Content;
                        }
                        else
                        {
                            HslCommunication.OperateResult<short> read541 = busTcpClient[i].ReadInt16("541");//DP1 Temper
                            if (read541.IsSuccess)
                                int6_1[i][0] = read541.Content;
                            HslCommunication.OperateResult<short> read543 = busTcpClient[i].ReadInt16("543");//MB1 Temper
                            if (read543.IsSuccess)
                                int6_1[i][1] = read543.Content;
                            HslCommunication.OperateResult<short> read544 = busTcpClient[i].ReadInt16("544");//MB1  EC Temper
                            if (read544.IsSuccess)
                                int6_1[i][2] = read544.Content;
                            HslCommunication.OperateResult<short> read545 = busTcpClient[i].ReadInt16("545");//DP Current
                            if (read545.IsSuccess)
                                int6_1[i][3] = read545.Content;
                            HslCommunication.OperateResult<short> read546 = busTcpClient[i].ReadInt16("546");//MB Current
                            if (read546.IsSuccess)
                                int6_1[i][4] = read546.Content;
                            HslCommunication.OperateResult<short> read547 = busTcpClient[i].ReadInt16("547");//DP Power
                            if (read547.IsSuccess)
                                int6_1[i][5] = read547.Content;
                            HslCommunication.OperateResult<short> read548 = busTcpClient[i].ReadInt16("548");//MB Power
                            if (read548.IsSuccess)
                                int6_1[i][6] = read548.Content;
                            HslCommunication.OperateResult<short> read549 = busTcpClient[i].ReadInt16("549");//N2flow
                            if (read549.IsSuccess)
                                int6_1[i][7] = read549.Content;
                            HslCommunication.OperateResult<short> read267 = busTcpClient[i].ReadInt16("267");//MB1 speed
                            if (read267.IsSuccess)
                                int6_1[i][8] = read267.Content;
                        }
                        */
                    }
                    ss1 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    /*
                    for (int j = 0; j < 6; j++)
                    {
                        if (j < 2)
                        {
                            sr.MysqlInsert(mycon, "INSERT INTO `pump`.`parameters" + (j + 1).ToString() + "`(`unitid`, `ip`, `DPtemper`, `DPcurrent`, `DPpressure`, `MBcurrent`,`MBfrequency`,`N2flow`, `time`) VALUES ('"
                       + (j + 1).ToString() + "','" + pumpIP[j] + "','" + int6_1[j][0] + "','" + int6_1[j][1] + "','" + int6_1[j][2] + "','" + int6_1[j][3] + "','" + int6_1[j][4] + "','" + int6_1[j][5] + "','" + ss1 + "')");
                        }
                        else
                        {
                            sr.MysqlInsert(mycon, "INSERT INTO `pump`.`parameters" + (j + 1).ToString() + "`(`unitid`, `ip`, `DPtemper`, `MBTemper`, `MBECTemper`, `DPCurrent`,`MBCurrent`,`DPPower`,`MBPower`,`N2flow`,`MBspeed`, `time`) VALUES ('"
                       + (j + 1).ToString() + "','" + pumpIP[j] + "','" + int6_1[j][0] + "','" + int6_1[j][1] + "','" + int6_1[j][2] + "','" + int6_1[j][3] + "','" + int6_1[j][4] + "','" + int6_1[j][5] + "','" + int6_1[j][6] + "','" + int6_1[j][7] + "','" + int6_1[j][8] + "','" + ss1 + "')");
                        }

                    }
                    */                   
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        public static void threadstart2()
        {
            while (true)
            {
                try
                {

                    Console.WriteLine("this is  thread start 2------" + stimer1++);
                    for (int i = 6; i < 12; i++)
                    {
                        Console.WriteLine(i + "---------" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff"));
                        /*
                        HslCommunication.OperateResult<short> read541 = busTcpClient[i].ReadInt16("541");//DP1 Temper
                        if (read541.IsSuccess)
                            int6_2[i - 6][0] = read541.Content;
                        HslCommunication.OperateResult<short> read543 = busTcpClient[i].ReadInt16("543");//MB1 Temper
                        if (read543.IsSuccess)
                            int6_2[i - 6][1] = read543.Content;
                        HslCommunication.OperateResult<short> read544 = busTcpClient[i].ReadInt16("544");//MB1  EC Temper
                        if (read544.IsSuccess)
                            int6_2[i - 6][2] = read544.Content;
                        HslCommunication.OperateResult<short> read545 = busTcpClient[i].ReadInt16("545");//DP Current
                        if (read545.IsSuccess)
                            int6_2[i - 6][3] = read545.Content;
                        HslCommunication.OperateResult<short> read546 = busTcpClient[i].ReadInt16("546");//MB Current
                        if (read546.IsSuccess)
                            int6_2[i - 6][4] = read546.Content;
                        HslCommunication.OperateResult<short> read547 = busTcpClient[i].ReadInt16("547");//DP Power
                        if (read547.IsSuccess)
                            int6_2[i - 6][5] = read547.Content;
                        HslCommunication.OperateResult<short> read548 = busTcpClient[i].ReadInt16("548");//MB Power
                        if (read548.IsSuccess)
                            int6_2[i - 6][6] = read548.Content;
                        HslCommunication.OperateResult<short> read549 = busTcpClient[i].ReadInt16("549");//N2flow
                        if (read549.IsSuccess)
                            int6_2[i - 6][7] = read549.Content;
                        HslCommunication.OperateResult<short> read267 = busTcpClient[i].ReadInt16("267");//MB1 speed
                        if (read267.IsSuccess)
                            int6_2[i - 6][8] = read267.Content;

                        */
                    }
                    ss2 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    /*
                    for (int j = 0; j < 6; j++)
                    {
                        sr.MysqlInsert(mycon, "INSERT INTO `pump`.`parameters" + (j + 7).ToString() + "`(`unitid`, `ip`, `DPtemper`, `MBTemper`, `MBECTemper`, `DPCurrent`,`MBCurrent`,`DPPower`,`MBPower`,`N2flow`,`MBspeed`, `time`) VALUES ('"
                       + (j + 7).ToString() + "','" + pumpIP[j + 6] + "','" + int6_2[j][0] + "','" + int6_2[j][1] + "','" + int6_2[j][2] + "','" + int6_2[j][3] + "','" + int6_2[j][4] + "','" + int6_2[j][5] + "','" + int6_2[j][6] + "','" + int6_2[j][7] + "','" + int6_2[j][8] + "','" + ss2 + "')");
                    }
                    */
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        public static void threadstart3()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("this is  thread start 3------" + stimer1++);
                    for (int i = 12; i < 18; i++)
                    {

                        Console.WriteLine(i + "---------" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff"));
                        /*
                        HslCommunication.OperateResult<short> read541 = busTcpClient[i].ReadInt16("541");//DP1 Temper
                        if (read541.IsSuccess)
                            int6_3[i - 12][0] = read541.Content;
                        HslCommunication.OperateResult<short> read543 = busTcpClient[i].ReadInt16("543");//MB1 Temper
                        if (read543.IsSuccess)
                            int6_3[i - 12][1] = read543.Content;
                        HslCommunication.OperateResult<short> read544 = busTcpClient[i].ReadInt16("544");//MB1  EC Temper
                        if (read544.IsSuccess)
                            int6_3[i - 12][2] = read544.Content;
                        HslCommunication.OperateResult<short> read545 = busTcpClient[i].ReadInt16("545");//DP Current
                        if (read545.IsSuccess)
                            int6_3[i - 12][3] = read545.Content;
                        HslCommunication.OperateResult<short> read546 = busTcpClient[i].ReadInt16("546");//MB Current
                        if (read546.IsSuccess)
                            int6_3[i - 12][4] = read546.Content;
                        HslCommunication.OperateResult<short> read547 = busTcpClient[i].ReadInt16("547");//DP Power
                        if (read547.IsSuccess)
                            int6_3[i - 12][5] = read547.Content;
                        HslCommunication.OperateResult<short> read548 = busTcpClient[i].ReadInt16("548");//MB Power
                        if (read548.IsSuccess)
                            int6_3[i - 12][6] = read548.Content;
                        HslCommunication.OperateResult<short> read549 = busTcpClient[i].ReadInt16("549");//N2flow
                        if (read549.IsSuccess)
                            int6_3[i - 12][7] = read549.Content;
                        HslCommunication.OperateResult<short> read267 = busTcpClient[i].ReadInt16("267");//MB1 speed
                        if (read267.IsSuccess)
                            int6_3[i - 12][8] = read267.Content;
                        */
                    }
                    ss3 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    /*
                    for (int j = 0; j < 6; j++)
                    {
                        sr.MysqlInsert(mycon, "INSERT INTO `pump`.`parameters" + (j + 13).ToString() + "`(`unitid`, `ip`, `DPtemper`, `MBTemper`, `MBECTemper`, `DPCurrent`,`MBCurrent`,`DPPower`,`MBPower`,`N2flow`,`MBspeed`, `time`) VALUES ('"
                       + (j + 13).ToString() + "','" + pumpIP[j + 12] + "','" + int6_3[j][0] + "','" + int6_3[j][1] + "','" + int6_3[j][2] + "','" + int6_3[j][3] + "','" + int6_3[j][4] + "','" + int6_3[j][5] + "','" + int6_3[j][6] + "','" + int6_3[j][7] + "','" + int6_3[j][8] + "','" + ss3 + "')");
                    }
                    */
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        public static void threadstart4()
        {
            while (true)
            {
                try
                {

                    Console.WriteLine("this is  thread start 4------" + stimer1++);
                    for (int i = 18; i < 24; i++)
                    {

                        Console.WriteLine(i + "---------" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff"));
                        /*
                        if (i < 20)
                        {
                            HslCommunication.OperateResult<short> read3003 = busTcpClient[i].ReadInt16("3003");//DP1 Temper
                            if (read3003.IsSuccess)
                                int6_4[i - 18][0] = read3003.Content;
                            HslCommunication.OperateResult<short> read3001 = busTcpClient[i].ReadInt16("3001");//DP1 Current
                            if (read3001.IsSuccess)
                                int6_4[i - 18][1] = read3001.Content;
                            HslCommunication.OperateResult<short> read3002 = busTcpClient[i].ReadInt16("3002");//DP1 Overpressure
                            if (read3002.IsSuccess)
                                int6_4[i - 18][2] = read3002.Content;
                            HslCommunication.OperateResult<short> read3023 = busTcpClient[i].ReadInt16("3023");//MB Current
                            if (read3023.IsSuccess)
                                int6_4[i - 18][3] = read3023.Content;
                            HslCommunication.OperateResult<short> read3028 = busTcpClient[i].ReadInt16("3028");//MB frequency
                            if (read3028.IsSuccess)
                                int6_4[i - 18][4] = read3028.Content;
                            HslCommunication.OperateResult<short> read3036 = busTcpClient[i].ReadInt16("3036");//N2flow
                            if (read3036.IsSuccess)
                                int6_4[i - 18][5] = read3036.Content;

                        }
                        else
                        {
                            HslCommunication.OperateResult<short> read541 = busTcpClient[i].ReadInt16("541");//DP1 Temper
                            if (read541.IsSuccess)
                                int6_4[i - 18][0] = read541.Content;
                            HslCommunication.OperateResult<short> read543 = busTcpClient[i].ReadInt16("543");//MB1 Temper
                            if (read543.IsSuccess)
                                int6_4[i - 18][1] = read543.Content;
                            HslCommunication.OperateResult<short> read544 = busTcpClient[i].ReadInt16("544");//MB1  EC Temper
                            if (read544.IsSuccess)
                                int6_4[i - 18][2] = read544.Content;
                            HslCommunication.OperateResult<short> read545 = busTcpClient[i].ReadInt16("545");//DP Current
                            if (read545.IsSuccess)
                                int6_4[i - 18][3] = read545.Content;
                            HslCommunication.OperateResult<short> read546 = busTcpClient[i].ReadInt16("546");//MB Current
                            if (read546.IsSuccess)
                                int6_4[i - 18][4] = read546.Content;
                            HslCommunication.OperateResult<short> read547 = busTcpClient[i].ReadInt16("547");//DP Power
                            if (read547.IsSuccess)
                                int6_4[i - 18][5] = read547.Content;
                            HslCommunication.OperateResult<short> read548 = busTcpClient[i].ReadInt16("548");//MB Power
                            if (read548.IsSuccess)
                                int6_4[i - 18][6] = read548.Content;
                            HslCommunication.OperateResult<short> read549 = busTcpClient[i].ReadInt16("549");//N2flow
                            if (read549.IsSuccess)
                                int6_4[i - 18][7] = read549.Content;
                            HslCommunication.OperateResult<short> read267 = busTcpClient[i].ReadInt16("267");//MB1 speed
                            if (read267.IsSuccess)
                                int6_4[i - 18][8] = read267.Content;

                        }
                        */

                    }
                    ss4 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    /*
                    for (int j = 0; j < 6; j++)
                    {
                        if (j < 2)
                        {
                            sr.MysqlInsert(mycon, "INSERT INTO `pump`.`parameters" + (j + 19).ToString() + "`(`unitid`, `ip`, `DPtemper`, `DPcurrent`, `DPpressure`, `MBcurrent`,`MBfrequency`,`N2flow`, `time`) VALUES ('"
                       + (j + 19).ToString() + "','" + pumpIP[j + 18] + "','" + int6_4[j][0] + "','" + int6_4[j][1] + "','" + int6_4[j][2] + "','" + int6_4[j][3] + "','" + int6_4[j][4] + "','" + int6_4[j][5] + "','" + ss4 + "')");
                        }
                        else
                        {
                            sr.MysqlInsert(mycon, "INSERT INTO `pump`.`parameters" + (j + 19).ToString() + "`(`unitid`, `ip`, `DPtemper`, `MBTemper`, `MBECTemper`, `DPCurrent`,`MBCurrent`,`DPPower`,`MBPower`,`N2flow`,`MBspeed`, `time`) VALUES ('"
                       + (j + 19).ToString() + "','" + pumpIP[j + 18] + "','" + int6_4[j][0] + "','" + int6_4[j][1] + "','" + int6_4[j][2] + "','" + int6_4[j][3] + "','" + int6_4[j][4] + "','" + int6_4[j][5] + "','" + int6_4[j][6] + "','" + int6_4[j][7] + "','" + int6_4[j][8] + "','" + ss4 + "')");
                        }

                    }
                    */                   
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        public static void threadstart5()
        {
            while (true)
            {
                try
                {

                    Console.WriteLine("this is  thread start 5------" + stimer1++);
                    for (int i = 24; i < 30; i++)
                    {

                        Console.WriteLine(i + "---------" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff"));
                        /*
                        HslCommunication.OperateResult<short> read541 = busTcpClient[i].ReadInt16("541");//DP1 Temper
                        if (read541.IsSuccess)
                            int6_5[i - 24][0] = read541.Content;
                        HslCommunication.OperateResult<short> read543 = busTcpClient[i].ReadInt16("543");//MB1 Temper
                        if (read543.IsSuccess)
                            int6_5[i - 24][1] = read543.Content;
                        HslCommunication.OperateResult<short> read544 = busTcpClient[i].ReadInt16("544");//MB1  EC Temper
                        if (read544.IsSuccess)
                            int6_5[i - 24][2] = read544.Content;
                        HslCommunication.OperateResult<short> read545 = busTcpClient[i].ReadInt16("545");//DP Current
                        if (read545.IsSuccess)
                            int6_5[i - 24][3] = read545.Content;
                        HslCommunication.OperateResult<short> read546 = busTcpClient[i].ReadInt16("546");//MB Current
                        if (read546.IsSuccess)
                            int6_5[i - 24][4] = read546.Content;
                        HslCommunication.OperateResult<short> read547 = busTcpClient[i].ReadInt16("547");//DP Power
                        if (read547.IsSuccess)
                            int6_5[i - 24][5] = read547.Content;
                        HslCommunication.OperateResult<short> read548 = busTcpClient[i].ReadInt16("548");//MB Power
                        if (read548.IsSuccess)
                            int6_5[i - 24][6] = read548.Content;
                        HslCommunication.OperateResult<short> read549 = busTcpClient[i].ReadInt16("549");//N2flow
                        if (read549.IsSuccess)
                            int6_5[i - 24][7] = read549.Content;
                        HslCommunication.OperateResult<short> read267 = busTcpClient[i].ReadInt16("267");//MB1 speed
                        if (read267.IsSuccess)
                            int6_5[i - 24][8] = read267.Content;
                        */                           
                    }
                    ss5 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    /*
                    for (int j = 0; j < 6; j++)
                    {
                        sr.MysqlInsert(mycon, "INSERT INTO `pump`.`parameters" + (j + 25).ToString() + "`(`unitid`, `ip`, `DPtemper`, `MBTemper`, `MBECTemper`, `DPCurrent`,`MBCurrent`,`DPPower`,`MBPower`,`N2flow`,`MBspeed`, `time`) VALUES ('"
                       + (j + 25).ToString() + "','" + pumpIP[j + 24] + "','" + int6_5[j][0] + "','" + int6_5[j][1] + "','" + int6_5[j][2] + "','" + int6_5[j][3] + "','" + int6_5[j][4] + "','" + int6_5[j][5] + "','" + int6_5[j][6] + "','" + int6_5[j][7] + "','" + int6_5[j][8] + "','" + ss5 + "')");
                    }
                    */
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
        public static void threadstart6()
        {
            while (true)
            {
                try
                {

                    Console.WriteLine("this is  thread start 1------" + stimer1++);
                    for (int i = 30; i < 36; i++)
                    {

                        Console.WriteLine(i + "---------" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss:ffff"));
                        /*
                        HslCommunication.OperateResult<short> read541 = busTcpClient[i].ReadInt16("541");//DP1 Temper
                        if (read541.IsSuccess)
                            int6_6[i - 30][0] = read541.Content;
                        HslCommunication.OperateResult<short> read543 = busTcpClient[i].ReadInt16("543");//MB1 Temper
                        if (read543.IsSuccess)
                            int6_6[i - 30][1] = read543.Content;
                        HslCommunication.OperateResult<short> read544 = busTcpClient[i].ReadInt16("544");//MB1  EC Temper
                        if (read544.IsSuccess)
                            int6_6[i - 30][2] = read544.Content;
                        HslCommunication.OperateResult<short> read545 = busTcpClient[i].ReadInt16("545");//DP Current
                        if (read545.IsSuccess)
                            int6_6[i - 30][3] = read545.Content;
                        HslCommunication.OperateResult<short> read546 = busTcpClient[i].ReadInt16("546");//MB Current
                        if (read546.IsSuccess)
                            int6_6[i - 30][4] = read546.Content;
                        HslCommunication.OperateResult<short> read547 = busTcpClient[i].ReadInt16("547");//DP Power
                        if (read547.IsSuccess)
                            int6_6[i - 30][5] = read547.Content;
                        HslCommunication.OperateResult<short> read548 = busTcpClient[i].ReadInt16("548");//MB Power
                        if (read548.IsSuccess)
                            int6_6[i - 30][6] = read548.Content;
                        HslCommunication.OperateResult<short> read549 = busTcpClient[i].ReadInt16("549");//N2flow
                        if (read549.IsSuccess)
                            int6_6[i - 30][7] = read549.Content;
                        HslCommunication.OperateResult<short> read267 = busTcpClient[i].ReadInt16("267");//MB1 speed
                        if (read267.IsSuccess)
                            int6_6[i - 30][8] = read267.Content;
                        */                           

                    }
                    ss6 = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                    /*
                    for (int j = 0; j < 6; j++)
                    {
                        sr.MysqlInsert(mycon, "INSERT INTO `pump`.`parameters" + (j + 31).ToString() + "`(`unitid`, `ip`, `DPtemper`, `MBTemper`, `MBECTemper`, `DPCurrent`,`MBCurrent`,`DPPower`,`MBPower`,`N2flow`,`MBspeed`, `time`) VALUES ('"
                       + (j + 31).ToString() + "','" + pumpIP[j + 30] + "','" + int6_6[j][0] + "','" + int6_6[j][1] + "','" + int6_6[j][2] + "','" + int6_6[j][3] + "','" + int6_6[j][4] + "','" + int6_6[j][5] + "','" + int6_6[j][6] + "','" + int6_6[j][7] + "','" + int6_6[j][8] + "','" + ss6 + "')");
                    }
                    */
                    Thread.Sleep(1000);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
