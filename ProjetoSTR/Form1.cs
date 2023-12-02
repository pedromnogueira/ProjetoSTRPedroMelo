using ScottPlot;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.ComponentModel;
using System.Globalization;

namespace ProjetoSTR
{

    public partial class Form1 : Form
    {
        int contadorRecebimentoPacoteModulo1 = 0;
        int indexOfcb = 0;

        JSON_DADOS_RECEBIDOS_CORRENTE dadosRecebidosEmFormatoJSONModulo1;
        JSON_DADOS_RECEBIDOS_CORRENTE dadosRecebidosEmFormatoJSONModulo1curto;

        JSON_DADOS_RECEBIDOS_LATLONG dadosRecebidosEmFormatoJSONModulo2;

        UdpClient usocketConexaoUDPModulo2 = null;
        UdpClient usocketConexaoUDPModulo1 = null;
        UdpClient UsocketConexaoUDPModulo1Curto = null;

        IPEndPoint ipConexaoRecebimentoUDPModulo2 = null;
        IPEndPoint ipConexaoEnvioUDPModulo2 = null;

        IPEndPoint ipConexaoRecebimentoUDPModulo1 = null;
        IPEndPoint ipConexaoEnvioUDPModulo1 = null;

        IPEndPoint ipConexaoRecebimentoUDPModulo1Curto = null;
        IPEndPoint ipConexaoEnvioUDPModulo1Curto = null;

        string menssagemRecebidaModulo1;
        byte[] bytesRecebidosModulo1;

        string menssagemRecebidaModulo1curto;
        byte[] bytesRecebidosModulo1curto;

        //---- Valores Modulo 1
        int contadoPacotesEnviados = 0;

        int[] valueCurto;

        int pacotesPS = 0;

        int contadorUnidadesGeradas = 0;
        ScottPlot.Plottable.DataLogger Logger;
        ScottPlot.Plottable.DataLogger Logger2;
        ScottPlot.Plottable.DataLogger Logger3;
        ScottPlot.Plottable.DataLogger Logger4;

        Thread[] listaThreadsUnidadesGeradorasModulo1;
        UnidadeGeradoraDadosMedicao[] listaUnidadesGeradorasDadosMedicao;
        public Mutex nossoMutex = new Mutex();
        bool pararRecebimentoDadosModulo1 = false;
        bool pararLogger = false;
        Thread threadRecebimentosPacotesModulo1 = null;
        Thread threadRecebimentosPacotesModulo1Curto = null;

        Thread plotarFila = null;
        Thread BufferThread = null;

        Thread Pacotes_seg = null;

        Queue<string> FilaUnidadesRecebidas = new Queue<string>();


        //------ Valores Módulo 2

        string mensagemRecebidaModulo2;
        string formatoPacoteModulo2;
        byte[] bytesRecebidosModulo2;
        byte[] bytesAEnviarModulo2;
        int valor_vetor_max = 0;
        int[] vetlat = new int[100000];
        int[] vetlong = new int[100000];
        int contadorRecebimentoPacoteModulo2 = 0;
        bool pararRecebimentoDadosModulo2 = false;
        bool pararEnvioDadosModulo2 = false;
        double latitude;
        double longitude;
        Thread threadRecebimentosPacotesModulo2 = null;
        Thread threadEnvioPacotesModulo2 = null;
        Thread plotarmod2 = null;


        public Form1()
        {
            Control.CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();

            Logger = formsPlot1.Plot.AddDataLogger();
            Logger2 = formsPlot2.Plot.AddDataLogger();
            Logger3 = formsPlot3.Plot.AddDataLogger();
            Logger4 = formsPlot4.Plot.AddDataLogger();

            formsPlot1.Plot.Title("Corrente I1", true, Color.Black, 12.0f);
            formsPlot2.Plot.Title("Corrente I2", true, Color.Black, 12.0f);
            formsPlot3.Plot.Title("Corrente I3", true, Color.Black, 12.0f);

            formsPlot1.Plot.XLabel("Pacote nº");
            formsPlot1.Plot.YLabel("Valor Corrente RMS(A)");
            formsPlot2.Plot.XLabel("Pacote nº");
            formsPlot2.Plot.YLabel("Valor Corrente RMS(A)");
            formsPlot3.Plot.XLabel("Pacote nº");
            formsPlot3.Plot.YLabel("Valor Corrente RMS(A)");

            formsPlot4.Plot.XLabel("Segundos");
            formsPlot4.Plot.YLabel("Pacotes Recebidos");


        }

        public void pacotes_porSegundo()
        {
            int contadorRecebimentoPacoteModulo1antigo;
            int pakt_seg = 0;
            int conts = 0;
            while (true)
            {
                contadorRecebimentoPacoteModulo1antigo = contadorRecebimentoPacoteModulo1;
                Thread.Sleep(1000);
                pakt_seg = contadorRecebimentoPacoteModulo1 - contadorRecebimentoPacoteModulo1antigo;
                Logger4.Add(conts, pakt_seg);
                conts++;
            }
        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        private void RecebimentoPacotesUDPModulo1()
        {
            while (true)
            {
                bytesRecebidosModulo1 = usocketConexaoUDPModulo1.Receive(ref ipConexaoRecebimentoUDPModulo1);
                menssagemRecebidaModulo1 = Encoding.ASCII.GetString(bytesRecebidosModulo1);
                FilaUnidadesRecebidas.Enqueue(menssagemRecebidaModulo1);

                contadorRecebimentoPacoteModulo1++;

            }
        }
        private void RecebimentoPacotesUDPModulo1curto()
        {
            while (true)
            {
                bytesRecebidosModulo1curto = UsocketConexaoUDPModulo1Curto.Receive(ref ipConexaoRecebimentoUDPModulo1Curto);
                menssagemRecebidaModulo1curto = Encoding.ASCII.GetString(bytesRecebidosModulo1curto);
                dadosRecebidosEmFormatoJSONModulo1curto = JsonConvert.DeserializeObject<JSON_DADOS_RECEBIDOS_CORRENTE>(menssagemRecebidaModulo1curto);
                //this.Invoke((MethodInvoker)delegate ()
                //{
                //    textBox1.Text += menssagemRecebidaModulo1curto + "\n";
                //});

                listView1.Items[dadosRecebidosEmFormatoJSONModulo1curto.idDispositivo - 1].BackColor = Color.Red;

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            formsPlot1.Refresh();
            formsPlot2.Refresh();
            formsPlot3.Refresh();
            formsPlot4.Refresh();
        }

        private void buttonIniciarMod1Iniciar_Click(object sender, EventArgs e)
        {
            comboBoxListaUnidadesGeradoras.SelectedIndex = 0;
            indexOfcb = comboBoxListaUnidadesGeradoras.SelectedIndex + 1;
            plotarFila = new Thread(ConsumirFila);
            plotarFila.Start();

            //detectarCurto();

            usocketConexaoUDPModulo1 = new UdpClient(1234);
            ipConexaoRecebimentoUDPModulo1 = new IPEndPoint(IPAddress.Any, 1234);
            ipConexaoEnvioUDPModulo1 = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 1234);
            threadRecebimentosPacotesModulo1 = new Thread(RecebimentoPacotesUDPModulo1);
            threadRecebimentosPacotesModulo1.Start();

            UsocketConexaoUDPModulo1Curto = new UdpClient(223);
            ipConexaoRecebimentoUDPModulo1Curto = new IPEndPoint(IPAddress.Any, 223);
            ipConexaoEnvioUDPModulo1Curto = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 223);
            threadRecebimentosPacotesModulo1Curto = new Thread(RecebimentoPacotesUDPModulo1curto);
            //threadRecebimentosPacotesModulo1Curto.Start();
            Pacotes_seg = new Thread(pacotes_porSegundo);
            Pacotes_seg.Start();

            int quantidadeUnidGeradoras = listViewMod1UnidGeradora.Items.Count;
            listaUnidadesGeradorasDadosMedicao = new UnidadeGeradoraDadosMedicao[quantidadeUnidGeradoras];
            listaThreadsUnidadesGeradorasModulo1 = new Thread[quantidadeUnidGeradoras];
            BufferThread = new Thread(Buffersize);
            BufferThread.Start();

            btAnalisarUnidade.Enabled = true;
            int codigo = 0;
            int freqEnvio = 0;
            int correnteOriginal = 0;
            int correnteCurto = 0;
            for (int i = 0; i < quantidadeUnidGeradoras; i++)
            {

                codigo = Convert.ToInt16(listViewMod1UnidGeradora.Items[i].SubItems[0].Text);
                freqEnvio = Convert.ToInt16(listViewMod1UnidGeradora.Items[i].SubItems[1].Text);
                correnteOriginal = Convert.ToInt16(listViewMod1UnidGeradora.Items[i].SubItems[2].Text);
                correnteCurto = Convert.ToInt16(listViewMod1UnidGeradora.Items[i].SubItems[3].Text);
                listaUnidadesGeradorasDadosMedicao[i] = new UnidadeGeradoraDadosMedicao(usocketConexaoUDPModulo1, UsocketConexaoUDPModulo1Curto, ipConexaoEnvioUDPModulo1, ipConexaoEnvioUDPModulo1Curto, nossoMutex, correnteOriginal, codigo, freqEnvio, correnteCurto, false);
                listView1.Items[i].BackColor = Color.Green;
                if (correnteCurto < correnteOriginal)
                {
                    listView1.Items[i].BackColor = Color.Red;
                }
            }

            //Parte 3: gera threads
            for (int i = 0; i < quantidadeUnidGeradoras; i++)
            {
                listaThreadsUnidadesGeradorasModulo1[i] = new Thread(new ThreadStart(listaUnidadesGeradorasDadosMedicao[i].EnviaPacotesUDPFrequentemente));
                listaThreadsUnidadesGeradorasModulo1[i].Name = "UnidGeradora" + i.ToString();
                listaThreadsUnidadesGeradorasModulo1[i].Start();
            }
        }

        private void buttonAdicionar_Click(object sender, EventArgs e)
        {
            listViewMod1UnidGeradora.Items.Add(new ListViewItem(new String[] { numericUpDownMod1CodUnidGen.Value.ToString(), numericUpDownMod1FreqEnvio.Value.ToString(), numericUpDownMod1Corrente.Value.ToString(), numericUpDownMod1Curto.Value.ToString() }));
            comboBoxListaUnidadesGeradoras.Items.Add("Unidade Geradora: " + numericUpDownMod1CodUnidGen.Value);
            listView1.Items.Add(new ListViewItem(new String[] { "Un. Ger: " + numericUpDownMod1CodUnidGen.Value.ToString() }));
            numericUpDownMod1CodUnidGen.Value = numericUpDownMod1CodUnidGen.Value + 1;
            contadorUnidadesGeradas++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listViewMod1UnidGeradora.Items.Clear();
            comboBoxListaUnidadesGeradoras.Items.Clear();
            numericUpDownMod1CodUnidGen.Value = 1;
            listView1.Items.Clear();
            contadorUnidadesGeradas = 0;
        }

        private void buttonPararEnvioV1_Click(object sender, EventArgs e)
        {
            //parte 0: inicializacoes de interface
            buttonPararEnvioV1.Enabled = false;
            contadorRecebimentoPacoteModulo1 = 0;
            //dadosPlotarGraficoModulo1.Clear(); <- Clear nos gráficos
            buttonIniciarMod1Iniciar.Enabled = true;
            pararRecebimentoDadosModulo1 = true;

            //Parte 1: para os objetos equivalantes a unidades geradoras            
            for (int i = 0; i < listaUnidadesGeradorasDadosMedicao.Length; i++)
            {
                listaUnidadesGeradorasDadosMedicao[i].pararEnvio = true; //vai forcar as threads pararem
            }
            Thread.Sleep(500);
            listaUnidadesGeradorasDadosMedicao = null;

            //Parte 2: fecha conexao UDP
            usocketConexaoUDPModulo1.Close();
            threadRecebimentosPacotesModulo1.Abort();
        }

        private void ConsumirFila()
        {
            pararLogger = false;
            Thread.Sleep(100);
            if (FilaUnidadesRecebidas.Count > 100)
            {
                while (true)
                {
                    if (pararLogger)
                        return;
                    String stringJSon = FilaUnidadesRecebidas.Dequeue();
                    dadosRecebidosEmFormatoJSONModulo1 = JsonConvert.DeserializeObject<JSON_DADOS_RECEBIDOS_CORRENTE>(stringJSon);
                    if (dadosRecebidosEmFormatoJSONModulo1.idDispositivo == indexOfcb)
                    {
                        Logger.Add(dadosRecebidosEmFormatoJSONModulo1.numPacote, dadosRecebidosEmFormatoJSONModulo1.Ia);
                        Logger2.Add(dadosRecebidosEmFormatoJSONModulo1.numPacote, dadosRecebidosEmFormatoJSONModulo1.Ib);
                        Logger3.Add(dadosRecebidosEmFormatoJSONModulo1.numPacote, dadosRecebidosEmFormatoJSONModulo1.Ic);
                    }
                    if (FilaUnidadesRecebidas.Count < 100)
                    {
                        Thread.Sleep(100);
                        ConsumirFila();
                    }

                }
            }
            else
            {
                Thread.Sleep(100);
                ConsumirFila();
            }
        }

        private void btAnalisarUnidade_Click(object sender, EventArgs e)
        {
            pararLogger = true;
            Logger.Clear();
            Logger2.Clear();
            Logger3.Clear();
            indexOfcb = comboBoxListaUnidadesGeradoras.SelectedIndex + 1;
            plotarFila = new Thread(ConsumirFila);
            plotarFila.Start();
            //textBox1.Text = FilaUnidadesRecebidas.Count.ToString();
        }
        public void Buffersize()
        {
            while (true)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    textboxBuffer.Text = FilaUnidadesRecebidas.Count.ToString();
                });
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }




        // -------------------------------------------------------------------------------------------------------------------
        //                       MODULO 2







        private void button1_Click(object sender, EventArgs e)
        {
            //buttonIniciarMod2.Enabled = false;
            //buttonPararMod2.Enabled = true;
            contadorRecebimentoPacoteModulo2 = 0;
            pararRecebimentoDadosModulo2 = false;
            pararEnvioDadosModulo2 = false;
            //progressBarEnvioModulo2.Maximum = (int)numericUpDownQtdePacotes.Value;
            //progressBarEnvioModulo2.Value = 0;
            latitude = Convert.ToDouble(textBoxLat.Text);
            longitude = Convert.ToDouble(textBoxLong.Text);

            //valor_vetor_max = numericUpDownQtdePacotes.Value;


            //Parte 1: inicia conexao UDP
            usocketConexaoUDPModulo2 = new UdpClient(1233);
            ipConexaoRecebimentoUDPModulo2 = new IPEndPoint(IPAddress.Any, 1233);
            ipConexaoEnvioUDPModulo2 = new IPEndPoint(IPAddress.Parse("255.255.255.255"), 1233);

            threadRecebimentosPacotesModulo2 = new Thread(RecebimentoPacotesUDPModulo2);
            threadRecebimentosPacotesModulo2.Start();

            threadEnvioPacotesModulo2 = new Thread(EnvioPacotesUDP_CEPModulo2);
            threadEnvioPacotesModulo2.Start();
            //timerPlotaModulo2SinaisEnviados.Start(); //para plotar sinais
            plotarmod2 = new Thread(plotar_grafico);
            plotarmod2.Start();

        }
        private void plotar_grafico()
        {
            Thread.Sleep(5000); // ESPERAR VETORES ENCHEREM
            for (int i = 0; i < numericUpDownQtdePacotes.Value; i++)
            {
                formsPlotMdulo2.Plot.AddPoint(vetlat[i], vetlong[i]);
            }
            formsPlotMdulo2.Refresh();

        }
        private void EnvioPacotesUDP_CEPModulo2()
        {
            Random rnd = new Random();

            int cordx;
            int cordy;

            double randomNegPos = 0;
            double somarvalor;

            for (int i = 0; i < numericUpDownQtdePacotes.Value; i++)
            {
                //randomNegPos = 2.00 * rnd.NextSingle() - 1.00;
                //if (i < numericUpDownQtdePacotesMesmaArea.Value)
                //{
                //    somarvalor = (rnd.Next(1, 10) / 500) * randomNegPos;
                //}
                //else
                //{
                //    somarvalor = (rnd.Next(1, 10) / 5) * randomNegPos;
                //}

                //latitude = somarvalor + latitude;
                //longitude = somarvalor + longitude;

                if (i < numericUpDownQtdePacotesMesmaArea.Value)
                {
                    cordx = rnd.Next(80000, 120000);
                    cordy = rnd.Next(80000, 120000);
                }
                else
                {
                    cordx = rnd.Next(0, 200000);
                    cordy = rnd.Next(0, 200000);
                }


                formatoPacoteModulo2 = "{'Lat':" + cordx.ToString(CultureInfo.InvariantCulture) +
                                       ",'Long':" + cordy.ToString(CultureInfo.InvariantCulture) +
                                       ",'codErro':95}";

                //"N", CultureInfo.CreateSpecificCulture("en-US")
                //progressBarEnvioModulo2.Value = i;
                bytesAEnviarModulo2 = Encoding.ASCII.GetBytes(formatoPacoteModulo2);
                if (usocketConexaoUDPModulo2 != null)
                    usocketConexaoUDPModulo2.Send(bytesAEnviarModulo2, bytesAEnviarModulo2.Length, ipConexaoEnvioUDPModulo2);
                if (pararEnvioDadosModulo2)
                    return;
                Thread.Sleep(10);
            }
            //timerPlotaModulo2SinaisEnviados.Stop(); //para plotar sinais
        }
        private void RecebimentoPacotesUDPModulo2()
        {
            while (true)
            {
                if (pararRecebimentoDadosModulo2)
                    return;

                //dadosRecebidosEmFormatoJSONModulo1 = JsonConvert.DeserializeObject<JSON_DADOS_RECEBIDOS_CORRENTE>(stringJSon);
                bytesRecebidosModulo2 = usocketConexaoUDPModulo2.Receive(ref ipConexaoRecebimentoUDPModulo2);
                mensagemRecebidaModulo2 = Encoding.ASCII.GetString(bytesRecebidosModulo2);
                dadosRecebidosEmFormatoJSONModulo2 = JsonConvert.DeserializeObject<JSON_DADOS_RECEBIDOS_LATLONG>(mensagemRecebidaModulo2);
                vetlat[contadorRecebimentoPacoteModulo2] = dadosRecebidosEmFormatoJSONModulo2.Lat;
                vetlong[contadorRecebimentoPacoteModulo2] = dadosRecebidosEmFormatoJSONModulo2.Long;


                //formsPlotMdulo2.Plot.AddPoint(dadosRecebidosEmFormatoJSONModulo2.Lat, dadosRecebidosEmFormatoJSONModulo2.Long);
                contadorRecebimentoPacoteModulo2++;

            }
        }































    }
    public class JSON_DADOS_RECEBIDOS_LATLONG
    {
        public int Lat { get; set; }

        public int Long { get; set; }

        public int codErro { get; set; }

    }
    public class JSON_DADOS_RECEBIDOS_CORRENTE
    {
        public int Ia { get; set; }
        public int Ib { get; set; }
        public int Ic { get; set; }
        public int numPacote { get; set; }
        public int idDispositivo { get; set; }
    }

    public class UnidadeGeradoraDadosMedicao
    {
        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Valor de corrente emitido pelo pacote")]
        [DisplayName("Corrente normal")]
        public int valorCorrente { get; set; }

        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Código desta unidade geradora de pacotes")]
        [DisplayName("COD")]
        public int codDestaUnidade { get; set; }

        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Frequencia de envio de pacotes em ms")]
        [DisplayName("Freq. envio")]
        public int freqEnvioPacotesMS { get; set; }

        [Browsable(true)]
        [ReadOnly(true)]
        [Description("Quantidade de pacotes enviados")]
        [DisplayName("Pacotes enviados")]
        public int contadoPacotesEnviados { get; set; }

        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Valor que indica se o item esta em curto")]
        [DisplayName("Valor curto")]
        public int valorCurto { get; set; }

        [Browsable(true)]
        [ReadOnly(false)]
        [Description("Indica se está em curto")]
        [DisplayName("Em curto?")]
        public bool estaCurto { get; set; }

        [Browsable(false)]
        public bool pararEnvio { get; set; }

        public Mutex nossoMutex;
        public UdpClient usocketConexaoUDP;
        public UdpClient usocketConexaoUDPcurto;
        public IPEndPoint ipConexaoEnvioUDP;
        public IPEndPoint ipConexaoEnvioUDPcurto;

        public UnidadeGeradoraDadosMedicao(UdpClient p_usocketConexaoUDP, UdpClient p_usocketConexaoUDPcurto, IPEndPoint p_ipConexaoEnvioUDP, IPEndPoint p_ipConexaoEnvioUDPcurto, Mutex p_nossoMutex, int p_valorCorrente, int p_codDestaUnidade, int p_freqEnvioPacotesMS, int p_valorCurto, bool p_estaCurto)
        {
            nossoMutex = p_nossoMutex;
            valorCorrente = p_valorCorrente;
            codDestaUnidade = p_codDestaUnidade;
            freqEnvioPacotesMS = p_freqEnvioPacotesMS;
            valorCurto = p_valorCurto;
            estaCurto = p_estaCurto;
            usocketConexaoUDP = p_usocketConexaoUDP;
            usocketConexaoUDPcurto = p_usocketConexaoUDPcurto;
            ipConexaoEnvioUDP = p_ipConexaoEnvioUDP;
            ipConexaoEnvioUDPcurto = p_ipConexaoEnvioUDPcurto;
            contadoPacotesEnviados = 0;
            pararEnvio = false;

        }
        public void EnviaPacotesUDPFrequentemente() //avi ser usaco como uma  thread
        {
            string formatoPacote;
            string corrente;
            byte[] bytes;

            while (true)
            {
                corrente = Convert.ToString(valorCorrente);
                if (contadoPacotesEnviados < 65000)
                    contadoPacotesEnviados++;
                else
                    contadoPacotesEnviados = 0;
                formatoPacote = "{'Ia':" + corrente +
                                ",'Ib':" + corrente +
                                ",'Ic':" + corrente +
                                ",'numPacote':" + contadoPacotesEnviados.ToString() +
                                ",'idDispositivo':" + codDestaUnidade.ToString() + "}";

                bytes = Encoding.ASCII.GetBytes(formatoPacote);


                nossoMutex.WaitOne(); //bloqueia esta regiao para 1 simples thread acessar
                if (usocketConexaoUDP != null)
                    usocketConexaoUDP.Send(bytes, bytes.Length, ipConexaoEnvioUDP);
                nossoMutex.ReleaseMutex(); //desbloqueia esta regiao 
                if (pararEnvio)
                    return;
                if (valorCorrente < valorCurto) //se nao estiver em curto
                    Thread.Sleep(freqEnvioPacotesMS); //aguarda ate proximo envio               
                else//esta em curto
                {
                    //usocketConexaoUDPcurto.Send(bytes, bytes.Length, ipConexaoEnvioUDPcurto);
                    Thread.Sleep(1); ////// <- Duvidas

                }
            }

        }

    }
}
