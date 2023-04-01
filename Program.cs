const int Nc = 10;
            const double R = 8.31451;
            double[] xi = new double[10];
         
            xi[0] = 88.1617;
            xi[1] = 6.5777;
            xi[2] = 1.49;
            xi[3] = 0.4352;
            xi[4] = 0.3001;
            xi[5] = 0.0869;
            xi[6] = 0.0636;
            xi[7] = 2.1247;
            xi[8] = 0.7423;
            xi[9] = 0.0178;
       

            double P_abs = 17;
            double T = (273.15 + 9); 
            Console.WriteLine("P = " + P_abs);
            Console.WriteLine("T = " + T);
            double[,] kij = new double[10, 10];
            kij[0, 0] = 1; 
            kij[0, 1] = 1; 
            kij[0, 2] = 1.007619; 
            kij[0, 3] = 0.997596; 
            kij[0, 4] = 1; 
            kij[0, 5] = 1.002529; 
            kij[0, 6] = 0.982962; 
            kij[0, 7] = 1.003630; 
            kij[0, 8] = 0.995933; 
            kij[0, 9] = 1; 

            kij[1, 2] = 0.986893; 
            kij[1, 3] = 1;
            kij[1, 4] = 1;
            kij[1, 5] = 1; 
            kij[1, 6] = 1; 
            kij[1, 7] = 1.007960; 
            kij[1, 8] = 1.008510; 
            kij[1, 9] = 1; 

            kij[2, 3] = 1; 
            kij[2, 4] = 1; 
            kij[2, 5] = 1; 
            kij[2, 6] = 1; 
            kij[2, 7] = 1; 
            kij[2, 8] = 1; 
            kij[2, 9] = 1; 

            kij[3, 4] = 1; 
            kij[3, 5] = 1; 
            kij[3, 6] = 1; 
            kij[3, 7] = 1; 
            kij[3, 8] = 1;
            kij[3, 9] = 1; 


            kij[4, 5] = 1; 
            kij[4, 6] = 1; 
            kij[4, 7] = 1; 
            kij[4, 8] = 1; 
            kij[4, 9] = 1; 

            kij[5, 6] = 1; 
            kij[5, 7] = 1; 
            kij[5, 8] = 1; 
            kij[5, 9] = 1; 

            kij[6, 7] = 1; 
            kij[6, 8] = 0.910183; 
            kij[6, 9] = 1;

            kij[7, 8] = 0.982361;
            kij[7, 9] = 0.982361; 

            kij[8, 9] = 1; 

            double[,] vij = new double[10, 10];
            vij[0, 0] = 1; 
            vij[0, 1] = 1; 
            vij[0, 2] = 0.990877; 
            vij[0, 3] = 0.992291; 
            vij[0, 4] = 1; 
            vij[0, 5] = 1.00367; 
            vij[0, 6] = 1.302576; 
            vij[0, 7] = 0.886106; 
            vij[0, 8] = 0.963827; 
            vij[0, 9] = 1; 

            vij[1, 2] = 1.065173; 
            vij[1, 3] = 1.25; 
            vij[1, 4] = 1.25; 
            vij[1, 5] = 1.25; 
            vij[1, 6] = 1; 
            vij[1, 7] = 0.816431; 
            vij[1, 8] = 0.96987; 
            vij[1, 9] = 1; 

            vij[2, 3] = 1; 
            vij[2, 4] = 1; 
            vij[2, 5] = 1; 
            vij[2, 6] = 1; 
            vij[2, 7] = 0.915502; 
            vij[2, 8] = 1; 
            vij[2, 9] = 1; 

            vij[3, 4] = 1; 
            vij[3, 5] = 1; 
            vij[3, 6] = 1; 
            vij[3, 7] = 0.993556;
            vij[3, 8] = 1;
            vij[3, 9] = 1; 


            vij[4, 5] = 1; 
            vij[4, 6] = 1; 
            vij[4, 7] = 1; 
            vij[4, 8] = 1; 
            vij[4, 9] = 1; 

            vij[5, 6] = 1; 
            vij[5, 7] = 1; 
            vij[5, 8] = 1; 
            vij[5, 9] = 1; 

            vij[6, 7] = 1; 
            vij[6, 8] = 1.066638; 
            vij[6, 9] = 1; 

            vij[7, 8] = 0.835058; 
            vij[7, 9] = 1; 

            vij[8, 9] = 1; 


            double[,] Eij = new double[10, 10];
            double[,] Gij = new double[10, 10];


            
            double[,] eij = new double[10, 10];
            eij[0, 0] = 1; 
            eij[0, 1] = 1; 
            eij[0, 2] = 0.994635; 
            eij[0, 3] = 0.989844; 
            eij[0, 4] = 1.01953; 
            eij[0, 5] = 0.999268; 
            eij[0, 6] = 1.107274; 
            eij[0, 7] = 0.97164; 
            eij[0, 8] = 0.960644; 
            eij[0, 9] = 1; 

            eij[1, 0] = 1; 
            eij[1, 1] = 1; 
            eij[1, 2] = 1.02256; 
            eij[1, 3] = 1.01306; 
            eij[1, 4] = 1; 
            eij[1, 5] = 1.00532; 
            eij[1, 6] = 1; 
            eij[1, 7] = 0.97012; 
            eij[1, 8] = 0.925053; 
            eij[1, 9] = 1; 

            eij[2, 0] = 0.994635; 
            eij[2, 1] = 1.02256; 
            eij[2, 2] = 1; 
            eij[2, 3] = 1.0049; 
            eij[2, 4] = 1; 
            eij[2, 5] = 1; 
            eij[2, 6] = 1; 
            eij[2, 7] = 0.945939; 
            eij[2, 8] = 0.960237; 
            eij[2, 9] = 1; 

            eij[3, 0] = 0.989844; 
            eij[3, 1] = 1.01306; 
            eij[3, 2] = 1.0049; 
            eij[3, 3] = 1;
            eij[3, 4] = 1;
            eij[3, 5] = 1; 
            eij[3, 6] = 1; 
            eij[3, 7] = 0.973384; 
            eij[3, 8] = 0.897362; 
            eij[3, 9] = 1; 

            eij[4, 0] = 1.01953; 
            eij[4, 1] = 1; 
            eij[4, 2] = 1; 
            eij[4, 3] = 1;
            eij[4, 4] = 1;
            eij[4, 5] = 1; 
            eij[4, 6] = 1;
            eij[4, 7] = 0.946914;
            eij[4, 8] = 0.906849; 
            eij[4, 9] = 1; 

            eij[5, 0] = 0.999268; 
            eij[5, 1] = 1.00532; 
            eij[5, 2] = 1; 
            eij[5, 3] = 1; 
            eij[5, 4] = 1; 
            eij[5, 5] = 1; 
            eij[5, 6] = 1; 
            eij[5, 7] = 0.94552; 
            eij[5, 8] = 0.859764; 
            eij[5, 9] = 1; 

            eij[6, 0] = 1.107274; 
            eij[6, 1] = 1; 
            eij[6, 2] = 1; 
            eij[6, 3] = 1; 
            eij[6, 4] = 1; 
            eij[6, 5] = 1;
            eij[6, 6] = 1;
            eij[6, 7] = 1; 
            eij[6, 8] = 0.855134; 
            eij[6, 9] = 1; 

            eij[7, 0] = 0.97164; 
            eij[7, 1] = 0.97012; 
            eij[7, 2] = 0.945939; 
            eij[7, 3] = 0.973384; 
            eij[7, 4] = 0.946914; 
            eij[7, 5] = 0.94552; 
            eij[7, 6] = 1; 
            eij[7, 7] = 1; 
            eij[7, 8] = 1.02274; 
            eij[7, 9] = 1;

            eij[8, 0] = 0.960644;
            eij[8, 1] = 0.925053; 
            eij[8, 2] = 0.960237; 
            eij[8, 3] = 0.897362; 
            eij[8, 4] = 0.906849; 
            eij[8, 5] = 0.859764; 
            eij[8, 6] = 0.855134; 
            eij[8, 7] = 1.02274; 
            eij[8, 8] = 1; 
            eij[8, 9] = 1; 

            eij[9, 0] = 1; 
            eij[9, 1] = 1; 
            eij[9, 2] = 1; 
            eij[9, 3] = 1;
            eij[9, 4] = 1;
            eij[9, 5] = 1; 
            eij[9, 6] = 1; 
            eij[9, 7] = 1; 
            eij[9, 8] = 1; 
            eij[9, 9] = 1; 


            
            double[,] gij = new double[10, 10];
            gij[0, 0] = 1; 
            gij[0, 1] = 1; 
            gij[0, 2] = 1; 
            gij[0, 3] = 1; 
            gij[0, 4] = 1; 
            gij[0, 5] = 1; 
            gij[0, 6] = 1; 
            gij[0, 7] = 1; 
            gij[0, 8] = 0.807653; 
            gij[0, 9] = 1; 

            gij[1, 0] = 1; 
            gij[1, 1] = 1; 
            gij[1, 2] = 1; 
            gij[1, 3] = 1;
            gij[1, 4] = 1; 
            gij[1, 5] = 1; 
            gij[1, 6] = 1; 
            gij[1, 7] = 1; 
            gij[1, 8] = 0.370296; 
            gij[1, 9] = 1; 

            gij[2, 0] = 1; 
            gij[2, 1] = 1; 
            gij[2, 2] = 1; 
            gij[2, 3] = 1;
            gij[2, 4] = 1;
            gij[2, 5] = 1; 
            gij[2, 6] = 1; 
            gij[2, 7] = 1; 
            gij[2, 8] = 1; 
            gij[2, 9] = 1; 

            gij[3, 0] = 1; 
            gij[3, 1] = 1; 
            gij[3, 2] = 1; 
            gij[3, 3] = 1; 
            gij[3, 4] = 1; 
            gij[3, 5] = 1; 
            gij[3, 6] = 1;
            gij[3, 7] = 1;
            gij[3, 8] = 1; 
            gij[3, 9] = 1; 
            gij[4, 1] = 1; 
            gij[4, 2] = 1; 
            gij[4, 3] = 1; 
            gij[4, 4] = 1; 
            gij[4, 5] = 1; 
            gij[4, 6] = 1; 
            gij[4, 7] = 1; 
            gij[4, 8] = 1; 
            gij[4, 9] = 1; 

            gij[5, 0] = 1; 
            gij[5, 1] = 1; 
            gij[5, 2] = 1; 
            gij[5, 3] = 1; 
            gij[5, 4] = 1; 
            gij[5, 5] = 1; 
            gij[5, 6] = 1; 
            gij[5, 7] = 1; 
            gij[5, 8] = 1; 
            gij[5, 9] = 1; 

            gij[6, 0] = 1; 
            gij[6, 1] = 1; 
            gij[6, 2] = 1; 
            gij[6, 3] = 1; 
            gij[6, 4] = 1; 
            gij[6, 5] = 1; 
            gij[6, 6] = 1; 
            gij[6, 7] = 1;
            gij[6, 8] = 1; 
            gij[6, 9] = 1;

            gij[7, 0] = 1; 
            gij[7, 1] = 1; 
            gij[7, 2] = 1; 
            gij[7, 3] = 1;
            gij[7, 4] = 1; 
            gij[7, 5] = 1; 
            gij[7, 6] = 1; 
            gij[7, 7] = 1;
            gij[7, 8] = 0.982746; 
            gij[7, 9] = 1;

            gij[8, 0] = 0.807653; 
            gij[8, 1] = 0.370296; 
            gij[8, 2] = 1; 
            gij[8, 3] = 1; 
            gij[8, 4] = 1; 
            gij[8, 5] = 1; 
            gij[8, 6] = 1; 
            gij[8, 7] = 0.982746; 
            gij[8, 8] = 1; 
            gij[8, 9] = 1; 

            gij[9, 0] = 1; 
            gij[9, 1] = 1; 
            gij[9, 2] = 1;
            gij[9, 3] = 1; 
            gij[9, 4] = 1; 
            gij[9, 5] = 1; 
            gij[9, 6] = 1; 
            gij[9, 7] = 1; 
            gij[9, 8] = 1; 
            gij[9, 9] = 1; 


            double[] ki = new double[10];
            ki[0] = 0.4619255;
            ki[1] = 0.5279209;
            ki[2] = 0.5837490;
            ki[3] = 0.6341423;
            ki[4] = 0.6406937;
            ki[5] = 0.6798307;
            ki[6] = 0.7175118;
            ki[7] = 0.4479153;
            ki[8] = 0.4557489;
            ki[9] = 0.3589888;

            double[] Mi = new double[10];
            Mi[0] = 16.043;
            Mi[1] = 30.070;
            Mi[2] = 44.097;
            Mi[3] = 58.123;
            Mi[4] = 58.123;
            Mi[5] = 72.150;
            Mi[6] = 86.177;
            Mi[7] = 28.0135;
            Mi[8] = 44.010;
            Mi[9] = 4.0026;

            double[] Qi = new double[10];
            Qi[0] = 0;
            Qi[1] = 0;
            Qi[2] = 0;
            Qi[3] = 0;
            Qi[4] = 0;
            Qi[5] = 0;
            Qi[6] = 0;
            Qi[7] = 0;
            Qi[8] = 0.69;
            Qi[9] = 0;


            double[] Ei = new double[10];
            Ei[0] = 151.3183;
            Ei[1] = 244.1667;
            Ei[2] = 298.1183;
            Ei[3] = 337.6389;
            Ei[4] = 324.0689;
            Ei[5] = 370.6823;
            Ei[6] = 402.636293;
            Ei[7] = 99.73778;
            Ei[8] = 241.9606;
            Ei[9] = 2.610111;

            double[] Fi = new double[10];
            Fi[0] = 0;
            Fi[1] = 0;
            Fi[2] = 0;
            Fi[3] = 0;
            Fi[4] = 0;
            Fi[5] = 0;
            Fi[6] = 0;
            Fi[7] = 0;
            Fi[8] = 0;
            Fi[9] = 0;

            double[] Si = new double[10];
            Si[0] = 0;
            Si[1] = 0;
            Si[2] = 0;
            Si[3] = 0;
            Si[4] = 0;
            Si[5] = 0;
            Si[6] = 0;
            Si[7] = 0;
            Si[8] = 0;
            Si[9] = 0;

            double[] Wi = new double[10];
            Wi[0] = 0;
            Wi[1] = 0;
            Wi[2] = 0;
            Wi[3] = 0;
            Wi[4] = 0;
            Wi[5] = 0;
            Wi[6] = 0;
            Wi[7] = 0;
            Wi[8] = 0;
            Wi[9] = 0;

            double[] Gi = new double[10];
            Gi[0] = 0;
            Gi[1] = 0.0793;
            Gi[2] = 0.141239;
            Gi[3] = 0.281835;
            Gi[4] = 0.256692;
            Gi[5] = 0.366911;
            Gi[6] = 0.289731;
            Gi[7] = 0.027815;
            Gi[8] = 0.189065;
            Gi[9] = 0;

            double[] an = new double[58];

            an[0] = 0.153832600;
            an[1] = 1.341953000;
            an[2] = -2.998583000;
            an[3] = -0.048312280;
            an[4] = 0.375796500;
            an[5] = -1.589575000;
            an[6] = -0.053588470;
            an[7] = 0.886594630;
            an[8] = -0.710237040;
            an[9] = -1.471722000;
            an[10] = 1.321850350;
            an[11] = -0.786659250;
            an[12] = 2.291290 * Math.Pow(10, -9);
            an[13] = 0.157672400;
            an[14] = -0.436386400;
            an[15] = -0.044081590;
            an[16] = -0.003433888;
            an[17] = 0.032059050;
            an[18] = 0.024873550;
            an[19] = 0.073322790;
            an[20] = -0.001600573;
            an[21] = 0.642470600;
            an[22] = -0.416260100;
            an[23] = -0.066899570;
            an[24] = 0.279179500;
            an[25] = -0.696605100;
            an[26] = -0.002860589;
            an[27] = -0.008098836;
            an[28] = 3.150547000;
            an[29] = 0.007224479;
            an[30] = -0.705752900;
            an[31] = 0.534979200;
            an[32] = -0.079314910;
            an[33] = -1.418465000;
            an[34] = -5.99905 * Math.Pow(10, -17);
            an[35] = 0.105840200;
            an[36] = 0.034317290;
            an[37] = -0.007022847;
            an[38] = 0.024955870;
            an[39] = 0.042968180;
            an[40] = 0.746545300;
            an[41] = -0.291961300;
            an[42] = 7.294616000;
            an[43] = -9.936757000;
            an[44] = -0.005399808;
            an[45] = -0.243256700;
            an[46] = 0.049870160;
            an[47] = 0.003733797;
            an[48] = 1.874951000;
            an[49] = 0.002168144;
            an[50] = -0.658716400;
            an[51] = 0.000205518;
            an[52] = 0.009776195;
            an[53] = -0.020487080;
            an[54] = 0.015573220;
            an[55] = 0.006862415;
            an[56] = -0.001226752;
            an[57] = 0.002850908;

            double[] un = new double[58];

            un[0] = 0.0;
            un[1] = 0.5;
            un[2] = 1.0;
            un[3] = 3.5;
            un[4] = -0.5;
            un[5] = 4.5;
            un[6] = 0.5;
            un[7] = 7.5;
            un[8] = 9.5;
            un[9] = 6.0;
            un[10] = 12.0;
            un[11] = 12.5;
            un[12] = -6.0;
            un[13] = 2.0;
            un[14] = 3.0;
            un[15] = 2.0;
            un[16] = 2.0;
            un[17] = 11.0;
            un[18] = -0.5;
            un[19] = 0.5;
            un[20] = 0.0;
            un[21] = 4.0;
            un[22] = 6.0;
            un[23] = 21.0;
            un[24] = 23.0;
            un[25] = 22.0;
            un[26] = -1.0;
            un[27] = -0.5;
            un[28] = 7.0;
            un[29] = -1.0;
            un[30] = 6.0;
            un[31] = 4.0;
            un[32] = 1.0;
            un[33] = 9.0;
            un[34] = -13.0;
            un[35] = 21.0;
            un[36] = 8.0;
            un[37] = -0.5;
            un[38] = 0.0;
            un[39] = 2.0;
            un[40] = 7.0;
            un[41] = 9.0;
            un[42] = 22.0;
            un[43] = 23.0;
            un[44] = 1.0;
            un[45] = 9.0;
            un[46] = 3.0;
            un[47] = 8.0;
            un[48] = 23.0;
            un[49] = 1.5;
            un[50] = 5.0;
            un[51] = -0.5;
            un[52] = 4.0;
            un[53] = 7.0;
            un[54] = 3.0;
            un[55] = 0.0;
            un[56] = 1.0;
            un[57] = 0.0;

            int[] bn = new int[58];

            bn[0] = 1;
            bn[1] = 1;
            bn[2] = 1;
            bn[3] = 1;
            bn[4] = 1;
            bn[5] = 1;
            bn[6] = 1;
            bn[7] = 1;
            bn[8] = 1;
            bn[9] = 1;
            bn[10] = 1;
            bn[11] = 1;
            bn[12] = 1;
            bn[13] = 1;
            bn[14] = 1;
            bn[15] = 1;
            bn[16] = 1;
            bn[17] = 1;
            bn[18] = 2;
            bn[19] = 2;
            bn[20] = 2;
            bn[21] = 2;
            bn[22] = 2;
            bn[23] = 2;
            bn[24] = 2;
            bn[25] = 2;
            bn[26] = 2;
            bn[27] = 3;
            bn[28] = 3;
            bn[29] = 3;
            bn[30] = 3;
            bn[31] = 3;
            bn[32] = 3;
            bn[33] = 3;
            bn[34] = 3;
            bn[35] = 3;
            bn[36] = 3;
            bn[37] = 4;
            bn[38] = 4;
            bn[39] = 4;
            bn[40] = 4;
            bn[41] = 4;
            bn[42] = 4;
            bn[43] = 4;
            bn[44] = 5;
            bn[45] = 5;
            bn[46] = 5;
            bn[47] = 5;
            bn[48] = 5;
            bn[49] = 6;
            bn[50] = 6;
            bn[51] = 7;
            bn[52] = 7;
            bn[53] = 8;
            bn[54] = 8;
            bn[55] = 8;
            bn[56] = 9;
            bn[57] = 9;

            int[] cn = new int[58];

            cn[0] = 0;
            cn[1] = 0;
            cn[2] = 0;
            cn[3] = 0;
            cn[4] = 0;
            cn[5] = 0;
            cn[6] = 0;
            cn[7] = 0;
            cn[8] = 0;
            cn[9] = 0;
            cn[10] = 0;
            cn[11] = 0;
            cn[12] = 1;
            cn[13] = 1;
            cn[14] = 1;
            cn[15] = 1;
            cn[16] = 1;
            cn[17] = 1;
            cn[18] = 0;
            cn[19] = 0;
            cn[20] = 1;
            cn[21] = 1;
            cn[22] = 1;
            cn[23] = 1;
            cn[24] = 1;
            cn[25] = 1;
            cn[26] = 1;
            cn[27] = 0;
            cn[28] = 1;
            cn[29] = 1;
            cn[30] = 1;
            cn[31] = 1;
            cn[32] = 1;
            cn[33] = 1;
            cn[34] = 1;
            cn[35] = 1;
            cn[36] = 1;
            cn[37] = 0;
            cn[38] = 0;
            cn[39] = 1;
            cn[40] = 1;
            cn[41] = 1;
            cn[42] = 1;
            cn[43] = 1;
            cn[44] = 0;
            cn[45] = 1;
            cn[46] = 1;
            cn[47] = 1;
            cn[48] = 1;
            cn[49] = 0;
            cn[50] = 1;
            cn[51] = 0;
            cn[52] = 1;
            cn[53] = 1;
            cn[54] = 1;
            cn[55] = 1;
            cn[56] = 1;
            cn[57] = 1;

            int[] kn = new int[58];

            kn[0] = 0;
            kn[1] = 0;
            kn[2] = 0;
            kn[3] = 0;
            kn[4] = 0;
            kn[5] = 0;
            kn[6] = 0;
            kn[7] = 0;
            kn[8] = 0;
            kn[9] = 0;
            kn[10] = 0;
            kn[11] = 0;
            kn[12] = 3;
            kn[13] = 2;
            kn[14] = 2;
            kn[15] = 2;
            kn[16] = 4;
            kn[17] = 4;
            kn[18] = 0;
            kn[19] = 0;
            kn[20] = 2;
            kn[21] = 2;
            kn[22] = 2;
            kn[23] = 4;
            kn[24] = 4;
            kn[25] = 4;
            kn[26] = 4;
            kn[27] = 0;
            kn[28] = 1;
            kn[29] = 1;
            kn[30] = 2;
            kn[31] = 2;
            kn[32] = 3;
            kn[33] = 3;
            kn[34] = 4;
            kn[35] = 4;
            kn[36] = 4;
            kn[37] = 0;
            kn[38] = 0;
            kn[39] = 2;
            kn[40] = 2;
            kn[41] = 2;
            kn[42] = 4;
            kn[43] = 4;
            kn[44] = 0;
            kn[45] = 2;
            kn[46] = 2;
            kn[47] = 4;
            kn[48] = 4;
            kn[49] = 0;
            kn[50] = 2;
            kn[51] = 0;
            kn[52] = 2;
            kn[53] = 1;
            kn[54] = 2;
            kn[55] = 2;
            kn[56] = 2;
            kn[57] = 2;

            int[] gn = new int[58];

            gn[0] = 0;
            gn[1] = 0;
            gn[2] = 0;
            gn[3] = 0;
            gn[4] = 1;
            gn[5] = 1;
            gn[6] = 0;
            gn[7] = 0;
            gn[8] = 0;
            gn[9] = 0;
            gn[10] = 0;
            gn[11] = 0;
            gn[12] = 0;
            gn[13] = 0;
            gn[14] = 0;
            gn[15] = 0;
            gn[16] = 0;
            gn[17] = 0;
            gn[18] = 0;
            gn[19] = 0;
            gn[20] = 0;
            gn[21] = 0;
            gn[22] = 0;
            gn[23] = 0;
            gn[24] = 1;
            gn[25] = 0;
            gn[26] = 0;
            gn[27] = 0;
            gn[28] = 1;
            gn[29] = 0;
            gn[30] = 0;
            gn[31] = 1;
            gn[32] = 1;
            gn[33] = 1;
            gn[34] = 0;
            gn[35] = 0;
            gn[36] = 0;
            gn[37] = 0;
            gn[38] = 0;
            gn[39] = 0;
            gn[40] = 0;
            gn[41] = 0;
            gn[42] = 0;
            gn[43] = 0;
            gn[44] = 0;
            gn[45] = 0;
            gn[46] = 0;
            gn[47] = 0;
            gn[48] = 0;
            gn[49] = 0;
            gn[50] = 1;
            gn[51] = 0;
            gn[52] = 0;
            gn[53] = 1;
            gn[54] = 0;
            gn[55] = 1;
            gn[56] = 0;
            gn[57] = 0;

            int[] qn = new int[58];
            qn[0] = 0;
            qn[1] = 0;
            qn[2] = 0;
            qn[3] = 0;
            qn[4] = 0;
            qn[5] = 0;
            qn[6] = 1;
            qn[7] = 0;
            qn[8] = 0;
            qn[9] = 0;
            qn[10] = 0;
            qn[11] = 0;
            qn[12] = 0;
            qn[13] = 0;
            qn[14] = 0;
            qn[15] = 1;
            qn[16] = 0;
            qn[17] = 0;
            qn[18] = 0;
            qn[19] = 0;
            qn[20] = 0;
            qn[21] = 0;
            qn[22] = 0;
            qn[23] = 0;
            qn[24] = 0;
            qn[25] = 1;
            qn[26] = 0;
            qn[27] = 1;
            qn[28] = 0;
            qn[29] = 0;
            qn[30] = 0;
            qn[31] = 0;
            qn[32] = 0;
            qn[33] = 0;
            qn[34] = 0;
            qn[35] = 0;
            qn[36] = 1;
            qn[37] = 0;
            qn[38] = 0;
            qn[39] = 0;
            qn[40] = 0;
            qn[41] = 1;
            qn[42] = 0;
            qn[43] = 0;
            qn[44] = 0;
            qn[45] = 0;
            qn[46] = 1;
            qn[47] = 0;
            qn[48] = 1;
            qn[49] = 0;
            qn[50] = 0;
            qn[51] = 1;
            qn[52] = 0;
            qn[53] = 0;
            qn[54] = 0;
            qn[55] = 0;
            qn[56] = 0;
            qn[57] = 1;
            int[] fn = new int[58];
            fn[0] = 0;
            fn[1] = 0;
            fn[2] = 0;
            fn[3] = 0;
            fn[4] = 0;
            fn[5] = 0;
            fn[6] = 0;
            fn[7] = 0;
            fn[8] = 0;
            fn[9] = 0;
            fn[10] = 0;
            fn[11] = 0;
            fn[12] = 1;
            fn[13] = 0;
            fn[14] = 0;
            fn[15] = 0;
            fn[16] = 0;
            fn[17] = 0;
            fn[18] = 0;
            fn[19] = 0;
            fn[20] = 0;
            fn[21] = 0;
            fn[22] = 0;
            fn[23] = 0;
            fn[24] = 0;
            fn[25] = 0;
            fn[26] = 1;
            fn[27] = 0;
            fn[28] = 0;
            fn[29] = 1;
            fn[30] = 0;
            fn[31] = 0;
            fn[32] = 0;
            fn[33] = 0;
            fn[34] = 1;
            fn[35] = 0;
            fn[36] = 0;
            fn[37] = 0;
            fn[38] = 0;
            fn[39] = 0;
            fn[40] = 0;
            fn[41] = 0;
            fn[42] = 0;
            fn[43] = 0;
            fn[44] = 0;
            fn[45] = 0;
            fn[46] = 0;
            fn[47] = 0;
            fn[48] = 0;
            fn[49] = 0;
            fn[50] = 0;
            fn[51] = 0;
            fn[52] = 0;
            fn[53] = 0;
            fn[54] = 0;
            fn[55] = 0;
            fn[56] = 0;
            fn[57] = 0;
            int[] sn = new int[58];
            sn[0] = 0;
            sn[1] = 0;
            sn[2] = 0;
            sn[3] = 0;
            sn[4] = 0;
            sn[5] = 0;
            sn[6] = 0;
            sn[7] = 1;
            sn[8] = 1;
            sn[9] = 0;
            sn[10] = 0;
            sn[11] = 0;
            sn[12] = 0;
            sn[13] = 0;
            sn[14] = 0;
            sn[15] = 0;
            sn[16] = 0;
            sn[17] = 0;
            sn[18] = 0;
            sn[19] = 0;
            sn[20] = 0;
            sn[21] = 0;
            sn[22] = 0;
            sn[23] = 0;
            sn[24] = 0;
            sn[25] = 0;
            sn[26] = 0;
            sn[27] = 0;
            sn[28] = 0;
            sn[29] = 0;
            sn[30] = 0;
            sn[31] = 0;
            sn[32] = 0;
            sn[33] = 0;
            sn[34] = 0;
            sn[35] = 0;
            sn[36] = 0;
            sn[37] = 0;
            sn[38] = 0;
            sn[39] = 0;
            sn[40] = 0;
            sn[41] = 0;
            sn[42] = 0;
            sn[43] = 0;
            sn[44] = 0;
            sn[45] = 0;
            sn[46] = 0;
            sn[47] = 0;
            sn[48] = 0;
            sn[49] = 0;
            sn[50] = 0;
            sn[51] = 0;
            sn[52] = 0;
            sn[53] = 0;
            sn[54] = 0;
            sn[55] = 0;
            sn[56] = 0;
            sn[57] = 0;
            int[] wn = new int[58];
            wn[0] = 0;
            wn[1] = 0;
            wn[2] = 0;
            wn[3] = 0;
            wn[4] = 0;
            wn[5] = 0;
            wn[6] = 0;
            wn[7] = 0;
            wn[8] = 0;
            wn[9] = 1;
            wn[10] = 1;
            wn[11] = 1;
            wn[12] = 0;
            wn[13] = 0;
            wn[14] = 0;
            wn[15] = 0;
            wn[16] = 0;
            wn[17] = 0;
            wn[18] = 0;
            wn[19] = 0;
            wn[20] = 0;
            wn[21] = 0;
            wn[22] = 0;
            wn[23] = 0;
            wn[24] = 0;
            wn[25] = 0;
            wn[26] = 0;
            wn[27] = 0;
            wn[28] = 0;
            wn[29] = 0;
            wn[30] = 0;
            wn[31] = 0;
            wn[32] = 0;
            wn[33] = 0;
            wn[34] = 0;
            wn[35] = 0;
            wn[36] = 0;
            wn[37] = 0;
            wn[38] = 0;
            wn[39] = 0;
            wn[40] = 0;
            wn[41] = 0;
            wn[42] = 0;
            wn[43] = 0;
            wn[44] = 0;
            wn[45] = 0;
            wn[46] = 0;
            wn[47] = 0;
            wn[48] = 0;
            wn[49] = 0;
            wn[50] = 0;
            wn[51] = 0;
            wn[52] = 0;
            wn[53] = 0;
            wn[54] = 0;
            wn[55] = 0;
            wn[56] = 0;
            wn[57] = 0;
            

            double Mm = 0; 
            for (int i = 0; i < Nc; i++)
            {
                Mm += xi[i] * Mi[i] / 100;
            }
            Console.WriteLine("Молярная масса смеси: " + Mm.ToString());
            
            double firstCompOfKx = 0;
            for (int i = 0; i < Nc; i++)
            {
                firstCompOfKx += xi[i] * Math.Pow(ki[i], (2.5)) / 100;
            }

            double secondCompOfKx = 0;
            for (int i = 0; i < Nc - 1; i++)
            {
                for (int j = i + 1; j < Nc; j++)
                {
                    secondCompOfKx += xi[i] / 100 * xi[j] / 100 * Math.Pow((ki[i] * ki[j]), (2.5)) * (Math.Pow((kij[i, j]), 5) - 1);
                }
            }

            double Kx = Math.Pow((Math.Pow(firstCompOfKx, 2) + 2 * secondCompOfKx), (0.2));
            Console.WriteLine("Смесевой параметр размера Kx: " + Kx.ToString());
            double p0m = Math.Pow((10 * Kx), -3) * 1 * R;
            Console.WriteLine("Параметр приведения для давления: " + p0m.ToString());


            double Q = 0;
            double F = 0;
            double firstV = 0;
            double firstG = 0;

            for (int i = 0; i < Nc; i++)
            {
                Q += xi[i] * Qi[i] / 100;
                F += Math.Pow(xi[i], 2) * Fi[i] / 100;
                firstV += xi[i] * Math.Pow(Ei[i], (2.5)) / 100;
                firstG += xi[i] * Gi[i] / 100;
                for (int j = 0; j < Nc; j++)
                {
                    Eij[i, j] = eij[i, j] * Math.Sqrt(Ei[i] * Ei[j]);
                    Gij[i, j] = gij[i, j] * (Gi[i] + Gi[j]) / 2;
                }
            }

            double secondV = 0;
            double secondG = 0;
            for (int i = 0; i < Nc - 1; i++)
            {
                for (int j = i + 1; j < Nc; j++)
                {
                    secondG += xi[i] * xi[j] * (Gi[i] + Gi[j]) * (gij[i, j] - 1) / 10000;
                    secondV += xi[i] * xi[j] * Math.Pow((Ei[i] * Ei[j]), (2.5)) * (Math.Pow(vij[i, j], 5) - 1) / 10000;
                }
            }

            double V = Math.Pow((Math.Pow(firstV, 2) + 2 * secondV), (0.2));
            double G = firstG + secondG;


            double[,,] Bnij = new double[58, 10, 10];

            for (int n = 0; n < 58; n++)
            {
                for (int i = 0; i < Nc; i++)
                {
                    for (int j = 0; j < Nc; j++)
                    {
                        Bnij[n, i, j] = Math.Pow((Gij[i, j] + 1 - gn[n]), gn[n]) * Math.Pow((Qi[i] * Qi[j] + 1 - qn[n]), qn[n]) * Math.Pow((Math.Sqrt(Fi[i] * Fi[j]) - fn[n]), fn[n]) * Math.Pow((Si[i] * Si[j] + 1 - sn[n]), sn[n]) * Math.Pow((Wi[i] * Wi[j] + 1 - wn[n]), wn[n]);
                    }
                }
            }

            double[] Bn = new double[58];
            double[] Cn = new double[58];
            double[] Dn = new double[58];
            double[] Un = new double[58];


            for (int n = 0; n < 58; n++)
            {
                Cn[n] = Math.Pow((G + 1 - gn[n]), gn[n]) * Math.Pow((Math.Pow(Q, 2) + 1 - qn[n]), qn[n]) * Math.Pow((F + 1 - fn[n]), fn[n]) * Math.Pow(V, un[n]);
                for (int i = 0; i < Nc; i++)
                {
                    for (int j = 0; j < Nc; j++)
                    {
                        Bn[n] += xi[i] * xi[j] * Bnij[n, i, j] * Math.Pow(Eij[i, j], un[n]) * Math.Pow((ki[i] * ki[j]), (1.5)) / 10000;
                    }
                }

                if (n >= 0 && n <= 11)
                {
                    Un[n] = 0;
                    Dn[n] = Bn[n] * Math.Pow(Kx, (-3));
                }
                else if (n >= 12 && n <= 17)
                {
                    Un[n] = Cn[n];
                    Dn[n] = Bn[n] * Math.Pow(Kx, (-3)) - Cn[n];
                }
                else
                {
                    Un[n] = Cn[n];
                    Dn[n] = 0;
                }
            }
           
           
            Console.WriteLine("Значение коэффициента G: " + G.ToString());
            Console.WriteLine("Значение коэффициента V: " + V.ToString());
            Console.WriteLine("Значение коэффициента Q: " + Q.ToString());
            Console.WriteLine("Значение коэффициента F: " + F.ToString());


            // Расчет начальной приведенной плотности
            
            double betta0 = 1000 * P_abs * Math.Pow(Kx, 3) / R / T;
            Console.WriteLine("Начальная приведенная плотность: " + betta0.ToString());
            double tau = T / 1;
            double prived_p = P_abs / p0m;

            double A0 = 0;
            double A1 = 0;
            // Безразмерный комплекс A0

            for (int n = 0; n < 58; n++)
            {
                A0 += an[n] * Math.Pow(betta0, bn[n]) * Math.Pow(tau, -un[n]) * (bn[n] * Dn[n] + (bn[n] - cn[n] * kn[n] * Math.Pow(betta0, kn[n])) * Un[n] * Math.Exp(-cn[n] * Math.Pow(betta0, kn[n])));
                A1 += an[n] * Math.Pow(betta0, bn[n]) * Math.Pow(tau, -un[n]) * ((bn[n] + 1) * bn[n] * Dn[n] + ((bn[n] - cn[n] * kn[n] * Math.Pow(betta0, kn[n])) * (bn[n] - cn[n] * kn[n] * Math.Pow(betta0, kn[n]) + 1) - cn[n] * Math.Pow(kn[n], 2) * Math.Pow(betta0, kn[n])) * Un[n] * Math.Exp(-cn[n] * Math.Pow(betta0, kn[n])));
            }
            Console.WriteLine("Безразмерный показатель A0: " + A0.ToString());
            Console.WriteLine("Безразмерный показатель A1: " + A1.ToString());

            double deltaBetta;
            double prived_p_ras;
            while (1 == 1)
            {
                deltaBetta = ((prived_p / tau) - (1 + A0) * betta0) / (1 + A1);
                betta0 += deltaBetta;
                A0 = 0;
                A1 = 0;
                for (int n = 0; n < 58; n++)
                {
                    A0 += an[n] * Math.Pow(betta0, bn[n]) * Math.Pow(tau, -un[n]) * (bn[n] * Dn[n] + (bn[n] - cn[n] * kn[n] * Math.Pow(betta0, kn[n])) * Un[n] * Math.Exp(-cn[n] * Math.Pow(betta0, kn[n])));
                    A1 += an[n] * Math.Pow(betta0, bn[n]) * Math.Pow(tau, -un[n]) * ((bn[n] + 1) * bn[n] * Dn[n] + ((bn[n] - cn[n] * kn[n] * Math.Pow(betta0, kn[n])) * (bn[n] - cn[n] * kn[n] * Math.Pow(betta0, kn[n]) + 1) - cn[n] * Math.Pow(kn[n], 2) * Math.Pow(betta0, kn[n])) * Un[n] * Math.Exp(-cn[n] * Math.Pow(betta0, kn[n])));
                }

                prived_p_ras = betta0 * tau * (1 + A0);
                if (Math.Abs((prived_p_ras - prived_p) / prived_p) < Math.Pow(10, -6))
                {
                    break;
                }
            }
            
             betta0.ToString();

            // Плотность смеси газа

            double plotn = Mm * Math.Pow(Kx, -3) * betta0;
            Console.WriteLine("Плотность смеси газа: " + plotn.ToString() + " кг/м^3");
            double z = 1 + A0;
            Console.WriteLine("Коэффициент сжимаемости природного газа: " + z.ToString());
