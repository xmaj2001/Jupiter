using iTextSharp.text;
using iTextSharp.text.pdf;
using Jupiter.Gestor;
using Jupiter.Model;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;

namespace Jupiter.Func
{
    public class Gerar
    {
        private static Gpagamentos gir = new Gpagamentos();
        private static CultureInfo cu = new CultureInfo("pt-AO");
        private static DirectoryInfo doc = new DirectoryInfo(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));
        private static string Angola = AppDomain.CurrentDomain.BaseDirectory + @"\xmaj\ens.jpg";
        public static void ReciboPagamento(Aluno aluno, Pagamento pagamento,string transcao)
        {
            var arqNome = "Recibo de Pagamento de "+ pagamento.Data.ToString("MMMM")+" de " + aluno.Nome + " Ano letivo " + aluno.Ano;
            var Recibo = Salvar(arqNome + ".pdf");
            if (Recibo != null)
            {
                try
                {
                    // Crie um novo documento
                    Document document = new Document(PageSize.A5);
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(Recibo, FileMode.Create));
                    document.SetPageSize(PageSize.A5);
                    document.Open();
                    // Defina uma fonte para o título
                    BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    Font fontEscola = new Font(baseFont, 9, Font.NORMAL);
                    // Logo
                    Image Logo = Image.GetInstance(Jupiter.Properties.Settings.Default.Logo);
                    Logo.ScaleToFit(50f, 50f);
                    Logo.Alignment = Element.ALIGN_CENTER;
                    document.Add(Logo);
                    Paragraph tras = new Paragraph($"Transição: {transcao}", new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL, BaseColor.BLACK));
                    tras.ExtraParagraphSpace = 0F;
                    tras.Alignment = Element.ALIGN_RIGHT;
                    document.Add(tras);
                    // FOTO ALUNO
                    Image FotoAluno = Image.GetInstance(aluno.Foto);
                    FotoAluno.ScaleToFit(70f, 70f);
                    var px = PageSize.A5.Width;
                    FotoAluno.SetAbsolutePosition(300,380);
                    document.Add(FotoAluno);

                    // Gere o código de barras
                    BarcodeWriter barcodeWriter = new BarcodeWriter();
                    EncodingOptions options = new EncodingOptions
                    {
                        Width = 300, // Largura do código de barras
                        Height = 100 // Altura do código de barras
                    };

                    barcodeWriter.Options = options;
                    barcodeWriter.Format = BarcodeFormat.CODE_128;
                    var code = aluno.ID.ToString() + "-" + aluno.Ano.ToString();
                    var barcodeBitmap = barcodeWriter.Write(code);

                    // Adicione o código de barras ao documento
                    iTextSharp.text.Image barcodeImage = iTextSharp.text.Image.GetInstance(barcodeBitmap, BaseColor.BLACK);
                    barcodeImage.ScaleAbsolute(150f, 40f);
                    barcodeImage.SetAbsolutePosition(135, 30);
                    document.Add(barcodeImage);
              
                    // Título do recibo
                    Paragraph title = new Paragraph("RECIBO DE PAGAMENTO", new Font(Font.FontFamily.HELVETICA, 10, Font.BOLD, BaseColor.BLACK));
                    title.Alignment = Element.ALIGN_CENTER;
                    document.Add(title);

                    Paragraph schoolInfo = new Paragraph();
                    schoolInfo.Font = new Font(Font.FontFamily.HELVETICA, 9, Font.NORMAL, BaseColor.BLACK);
                    schoolInfo.Alignment = Element.ALIGN_CENTER;
                    schoolInfo.Add(new Phrase(Jupiter.Properties.Settings.Default.Escola.ToUpper(),fontEscola));
                    schoolInfo.SpacingAfter = 14F;
                    document.Add(schoolInfo);

                    //// Informações do aluno
                    Paragraph studentInfo = new Paragraph();
                    studentInfo.Alignment = Element.ALIGN_LEFT;
                    studentInfo.Font = new Font(Font.FontFamily.HELVETICA, 9, Font.NORMAL, BaseColor.BLACK);
                    studentInfo.SpacingBefore = 5f;
                    studentInfo.SpacingAfter = 10f;
                    studentInfo.Add("Aluno: " + aluno.Nome + "\n");
                    studentInfo.Add("Nº: " + aluno.Numero + "\n");
                    studentInfo.Add("Classe: " + aluno.Classe + "ª" + "\n");
                    studentInfo.Add("Turma: " + aluno.Turma + "\n");
                    studentInfo.Add("Sala: " + aluno.Sala + "\n");
                    studentInfo.Add("Ano Letivo: " + aluno.Ano + "\n");
                    document.Add(studentInfo);

                    // Informações do pagamento
                    Paragraph HeaderPagamento = new Paragraph(new Phrase("PAGAMENTO", new Font(Font.FontFamily.HELVETICA, 10, Font.BOLD, BaseColor.BLACK)));
                    HeaderPagamento.Alignment = Element.ALIGN_CENTER;
                    document.Add(HeaderPagamento);
                    Paragraph Pagamento = new Paragraph();
                    Pagamento.Alignment = Element.ALIGN_CENTER;
                    Pagamento.SpacingBefore = 5f;
                    Pagamento.SpacingAfter = 10f;

                   var font_routtulas = new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.GRAY);
                   var font_routtulas_2 = new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.BLACK);
                   var font_routtulas_3 = new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL, BaseColor.BLACK);
                    var font_dados = new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.BLACK);
                   var font_DATA = new Font(Font.FontFamily.HELVETICA, 9, Font.BOLD, BaseColor.GRAY);

                    var mes = new Paragraph("MÊS: ", font_routtulas);
                    mes.Alignment = Element.ALIGN_CENTER;
                    mes.Add(new Phrase(pagamento.Data.ToString("MMMM").ToUpper(), font_dados));
                    //----------------------------------------------------------------------------------
                    var PROPINA = new Paragraph("PROPINA: ", font_routtulas);
                    PROPINA.Alignment = Element.ALIGN_CENTER;
                    PROPINA.Add(new Phrase(pagamento.Propina.ToString("C",cu), font_dados));
                    //----------------------------------------------------------------------------------
                    var MULTA = new Paragraph("MULTA: ", font_routtulas);
                    MULTA.Alignment = Element.ALIGN_CENTER;
                    MULTA.Add(new Phrase(pagamento.Multa.ToString("C", cu), font_dados));
                    //----------------------------------------------------------------------------------
                    var Total = new Paragraph("TOTAL: ", font_routtulas);
                    Total.Alignment = Element.ALIGN_CENTER;
                    Total.Add(new Phrase(pagamento.Total.ToString("C", cu), font_dados));
                    //----------------------------------------------------------------------------------
                    var DATA = new Paragraph("DATA", font_routtulas_2);
                    DATA.SpacingBefore = 10f;
                    DATA.Alignment = Element.ALIGN_CENTER;
                    DATA.Add(new Paragraph(pagamento.Create.ToString(), font_DATA) {Alignment= Element.ALIGN_CENTER });
                    //----------------------------------------------------------------------------------
                    var info = "PAGAMAMENTO EM";
                    if (pagamento.TPA)
                    {
                        info = "PAGAMAMENTO POR";
                    }
                    var TIPOP = new Paragraph(info, font_routtulas_3);
                    TIPOP.SpacingBefore = 10f;
                    TIPOP.Alignment = Element.ALIGN_CENTER;
                    TIPOP.Add(new Paragraph(pagamento.TipoInfo, font_dados) { Alignment = Element.ALIGN_CENTER });
                    //----------------------------------------------------------------------------------
                    Pagamento.Add(mes);
                    Pagamento.Add(PROPINA);
                    Pagamento.Add(MULTA);
                    Pagamento.Add(Total);
                    Pagamento.Add(DATA);
                    Pagamento.Add(TIPOP);

                    document.Add(Pagamento);
                  
                    // Rodapé
                    BaseFont baseFont2 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    Font footerd = new Font(baseFont2, 10, Font.NORMAL);
                    Paragraph footer = new Paragraph("EMITIDO: " + DateTime.Now.Date.ToString("d"), footerd);
                    footer.Alignment = Element.ALIGN_CENTER;
                    document.Add(footer);
                    // Feche o documento
                    document.Close();
                    if (File.Exists(Recibo))
                    {
                        System.Diagnostics.Process.Start(Recibo);
                    }
                }
                catch (Exception er)
                {
                    System.Windows.MessageBox.Show("Não foi possível gerar o Recibo: " + er.Message);
                }
            }
        }
        public static void ReciboPagamento(Aluno aluno, List<Pagamento> pagamentos, string transcao)
        {
            var arqNome = "Recibo de Pagamento de " + aluno.Nome + " Ano letivo " + aluno.Ano;
            var Recibo = Salvar(arqNome + ".pdf");
            if (Recibo != null)
            {
                try
                {
                    // Crie um novo documento
                    Document document = new Document(PageSize.A5);
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(Recibo, FileMode.Create));
                    document.Open();
                    // Defina uma fonte para o título
                    BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    Font titleFont = new Font(baseFont, 16, Font.BOLD);
                  
                    // Número do recibo
                    Paragraph paymentInfo = new Paragraph();
                    paymentInfo.Font = new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL, BaseColor.BLACK);
                    paymentInfo.Add($"Transação: {transcao}\n");
                    paymentInfo.Alignment = Element.ALIGN_RIGHT;
                    document.Add(paymentInfo);
                    // Logo
                    Image Logo = Image.GetInstance(Jupiter.Properties.Settings.Default.Logo);
                    Logo.ScaleToFit(50f, 50f);
                    Logo.IndentationRight = -50f;
                    document.Add(Logo);
                    // FOTO ALUNO
                    Image FotoAluno = Image.GetInstance(aluno.Foto);
                    FotoAluno.ScaleToFit(70, 70);
                    FotoAluno.SetAbsolutePosition(300, 370);
                    document.Add(FotoAluno);

                    //// Gere o código de barras
                    //BarcodeWriter barcodeWriter = new BarcodeWriter();
                    //EncodingOptions options = new EncodingOptions
                    //{
                    //    Width = 300, // Largura do código de barras
                    //    Height = 100 // Altura do código de barras
                    //};
                    //barcodeWriter.Options = options;
                    //barcodeWriter.Format = BarcodeFormat.CODE_128;
                    //var code = aluno.Numero.ToString() + "-" + aluno.Ano.ToString();
                    //var barcodeBitmap = barcodeWriter.Write(code);
                    //// Adicione o código de barras ao documento
                    //iTextSharp.text.Image barcodeImage = iTextSharp.text.Image.GetInstance(barcodeBitmap, BaseColor.BLACK);
                    //barcodeImage.ScaleAbsolute(200f, 50f);
                    //barcodeImage.SetAbsolutePosition(PageSize.A5.Width - 200, 20);
                    //document.Add(barcodeImage);

                    // Título do recibo
                    Paragraph title = new Paragraph("RECIBO DE PAGAMENTO", titleFont);
                    title.Alignment = Element.ALIGN_LEFT;
                    document.Add(title);
                    Font fontEscola = new Font(baseFont, 9, Font.NORMAL);
                    Paragraph schoolInfo = new Paragraph();
                    schoolInfo.Alignment = Element.ALIGN_LEFT;
                    schoolInfo.Add(new Phrase(Jupiter.Properties.Settings.Default.Escola.ToUpper(), fontEscola));
                    document.Add(schoolInfo);
                    //// Informações do aluno
                    Paragraph studentInfo = new Paragraph();
                    studentInfo.Alignment = Element.ALIGN_LEFT;
                    studentInfo.Font = new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL, BaseColor.BLACK);
                    studentInfo.SpacingBefore = 10f;
                    studentInfo.SpacingAfter = 10f;
                    studentInfo.Add("Aluno: " + aluno.Nome + "\n");
                    studentInfo.Add("Nº: " + aluno.Numero + "\n");
                    studentInfo.Add("Classe: " + aluno.Classe + "ª" + "\n");
                    studentInfo.Add("Turma: " + aluno.Turma + "\n");
                    studentInfo.Add("Sala: " + aluno.Sala + "\n");
                    studentInfo.Add("Ano Letivo: " + aluno.Ano + "\n");
                    document.Add(studentInfo);
                    // Informações do pagamento

                    //// Tabela de pagamentos
                    var fontHeader = new Font(Font.FontFamily.HELVETICA,8, Font.NORMAL, BaseColor.WHITE);
                    var fontdados = new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL, BaseColor.BLACK);
                    var fontdados2 = new Font(Font.FontFamily.HELVETICA, 6, Font.NORMAL, BaseColor.BLACK);
                    PdfPTable paymentTable = new PdfPTable(6);
                    paymentTable.SpacingBefore = 10f;
                    paymentTable.WidthPercentage = 100f;
                    var celulaMes = new PdfPCell(new Phrase("MÊS", fontHeader));
                    celulaMes.BackgroundColor = BaseColor.BLACK;
                    celulaMes.BorderColor = BaseColor.BLACK;
                    celulaMes.HorizontalAlignment = Element.ALIGN_CENTER;
                    celulaMes.Padding = 5;
                    paymentTable.AddCell(celulaMes);

                    var Propina = new PdfPCell(new Phrase("PROPINA", fontHeader));
                    Propina.BackgroundColor = BaseColor.BLACK;
                    Propina.BorderColor = BaseColor.BLACK;
                    Propina.HorizontalAlignment = Element.ALIGN_CENTER;
                    Propina.Padding = 5;
                    paymentTable.AddCell(Propina);

                    var Multa = new PdfPCell(new Phrase("MULTA", fontHeader));
                    Multa.BackgroundColor = BaseColor.BLACK;
                    Multa.BorderColor = BaseColor.BLACK;
                    Multa.HorizontalAlignment = Element.ALIGN_CENTER;
                    Multa.Padding = 5;
                    paymentTable.AddCell(Multa);

                    var Total = new PdfPCell(new Phrase("TOTAL", fontHeader));
                    Total.BackgroundColor = BaseColor.BLACK;
                    Total.BorderColor = BaseColor.BLACK;
                    Total.HorizontalAlignment = Element.ALIGN_CENTER;
                    Total.Padding = 5;
                    paymentTable.AddCell(Total);

                    var FEITO = new PdfPCell(new Phrase("PAGO", fontHeader));
                    FEITO.BackgroundColor = BaseColor.BLACK;
                    FEITO.BorderColor = BaseColor.BLACK;
                    FEITO.HorizontalAlignment = Element.ALIGN_CENTER;
                    FEITO.Padding = 5;
                    paymentTable.AddCell(FEITO);

                    var Data = new PdfPCell(new Phrase("DATA", fontHeader));
                    Data.BackgroundColor = BaseColor.BLACK;
                    Data.BorderColor = BaseColor.BLACK;
                    Data.HorizontalAlignment = Element.ALIGN_CENTER;
                    Data.Padding = 5;
                    paymentTable.AddCell(Data);
                    decimal Valortotal = 0;
                    foreach (var item in pagamentos)
                    {
                        Valortotal += item.Total;
                        paymentTable.AddCell(new PdfPCell(new Phrase(item.Data.ToString("MMMM").ToUpper(), fontdados)) { Padding = 5, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_LEFT });

                        paymentTable.AddCell(new PdfPCell(new Phrase(item.Propina.ToString("C",cu), fontdados)) { Padding = 5, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_CENTER });

                        paymentTable.AddCell(new PdfPCell(new Phrase(item.MultaInfo, fontdados)) { Padding = 5, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_CENTER });

                        paymentTable.AddCell(new PdfPCell(new Phrase((item.Propina + item.Multa).ToString("C", cu), fontdados)) { Padding = 5, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_CENTER });

                        paymentTable.AddCell(new PdfPCell(new Phrase(item.TipoInfo, fontdados2)) { Padding = 5, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_CENTER });

                        paymentTable.AddCell(new PdfPCell(new Phrase(item.Criado.ToString("d"), fontdados)) { Padding = 5, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_CENTER });
                    }

                    document.Add(paymentTable);
                    // Rodapé
                    var fonttTotal = new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.BLACK);
                    Paragraph TOTAL = new Paragraph();
                    TOTAL.Alignment = Element.ALIGN_LEFT;
                    TOTAL.SpacingBefore = 5f;
                    TOTAL.Add(new Phrase("TOTAL: ", new Font(Font.FontFamily.HELVETICA, 10, Font.BOLD, BaseColor.GRAY)));
                    TOTAL.Add(new Phrase(Valortotal.ToString("C", cu), fonttTotal));
                    document.Add(TOTAL);

                    BaseFont baseFont2 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    Font footerd = new Font(baseFont2, 10, Font.NORMAL);
                   
                    Paragraph footer = new Paragraph("Data: " + DateTime.Now.Date.ToString("d"), footerd);
                    footer.Alignment = Element.ALIGN_LEFT;
                    document.Add(footer);
                    // Feche o documento
                    document.Close();
                    if (File.Exists(Recibo))
                    {
                        System.Diagnostics.Process.Start(Recibo);
                    }
                }
                catch (Exception er)
                {
                    System.Windows.MessageBox.Show("Não foi possível gerar o Recibo: " + er.Message);
                }
            }
        }
        public static void RelatorioPagamento(Aluno aluno, List<Pagamento> pagamentos)
        {
            var arqNome = "Relatório de Pagamento de " + aluno.Nome + " Ano letivo " + aluno.Ano;
            var relatorio = Salvar(arqNome + ".pdf");
            if (relatorio != null)
            {
                try
                {
                    // Crie um novo documento
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(relatorio, FileMode.Create));
                    document.Open();
                    // Defina uma fonte para o título
                    BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    Font titleFont = new Font(baseFont, 16, Font.BOLD);

                    // Logo
                    Image Logo = Image.GetInstance(Jupiter.Properties.Settings.Default.Logo);
                    Logo.ScaleToFit(50f, 50f);
                    Logo.Alignment = Element.ALIGN_CENTER;
                    document.Add(Logo);
                    // Título do recibo
                    Paragraph title = new Paragraph("RELATÓRIO DE PAGAMENTO", titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    document.Add(title);
                    Font fontEscola = new Font(baseFont, 10, Font.NORMAL);
                    Paragraph schoolInfo = new Paragraph();
                    schoolInfo.Alignment = Element.ALIGN_CENTER;
                    schoolInfo.Add(new Phrase(Jupiter.Properties.Settings.Default.Escola.ToUpper(), fontEscola));
                    document.Add(schoolInfo);

                    // FOTO ALUNO
                    Image FotoAluno = Image.GetInstance(aluno.Foto);
                    FotoAluno.ScaleToFit(100f, 100f);
                    var px = PageSize.A4.Width;
                    FotoAluno.SetAbsolutePosition(px - 150, 620);
                    document.Add(FotoAluno);
                    // Gere o código de barras
                    BarcodeWriter barcodeWriter = new BarcodeWriter();
                    EncodingOptions options = new EncodingOptions
                    {
                        Width = 300, // Largura do código de barras
                        Height = 100 // Altura do código de barras
                    };
                    barcodeWriter.Options = options;
                    barcodeWriter.Format = BarcodeFormat.CODE_128;
                    var code = aluno.ID.ToString() + "-" + aluno.Ano.ToString();
                    var barcodeBitmap = barcodeWriter.Write(code);
                    // Adicione o código de barras ao documento
                    iTextSharp.text.Image barcodeImage = iTextSharp.text.Image.GetInstance(barcodeBitmap, BaseColor.BLACK);
                    barcodeImage.ScaleAbsolute(200f, 50f);
                    barcodeImage.SetAbsolutePosition(200, 100);
                    document.Add(barcodeImage);
                    //// Informações do aluno
                    Paragraph studentInfo = new Paragraph();
                    studentInfo.Alignment = Element.ALIGN_LEFT;
                    studentInfo.SpacingBefore = 8f;
                    studentInfo.SpacingAfter = 10f;
                    studentInfo.Add("Aluno: " + aluno.Nome + "\n");
                    studentInfo.Add("Nº: " + aluno.Numero + "\n");
                    studentInfo.Add("Turma: " + aluno.Turma + "\n");
                    studentInfo.Add("Sala: " + aluno.Sala + "\n");
                    studentInfo.Add("Classe: " + aluno.Classe + "ª" + "\n");
                    studentInfo.Add("Ano Letivo: " + aluno.Ano + "\n");
                    document.Add(studentInfo);
                    // Informações do pagamento
                    //// Tabela de pagamentos
                    PdfPTable paymentTable = new PdfPTable(5);
                    paymentTable.SpacingBefore = 10f;
                    paymentTable.WidthPercentage = 100f;
                    var celulaMes = new PdfPCell(new Phrase("Mês", new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL, BaseColor.WHITE)));
                    celulaMes.BackgroundColor = BaseColor.BLACK;
                    celulaMes.BorderColor = BaseColor.BLACK;
                    celulaMes.HorizontalAlignment = Element.ALIGN_CENTER;
                    celulaMes.Padding = 5;
                    paymentTable.AddCell(celulaMes);

                    var Propina = new PdfPCell(new Phrase("Propina", new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL, BaseColor.WHITE)));
                    Propina.BackgroundColor = BaseColor.BLACK;
                    Propina.BorderColor = BaseColor.BLACK;
                    Propina.HorizontalAlignment = Element.ALIGN_CENTER;
                    Propina.Padding = 5;
                    paymentTable.AddCell(Propina);

                    var Multa = new PdfPCell(new Phrase("Multa", new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL, BaseColor.WHITE)));
                    Multa.BackgroundColor = BaseColor.BLACK;
                    Multa.BorderColor = BaseColor.BLACK;
                    Multa.HorizontalAlignment = Element.ALIGN_CENTER;
                    Multa.Padding = 5;
                    paymentTable.AddCell(Multa);

                    var Total = new PdfPCell(new Phrase("Total", new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL, BaseColor.WHITE)));
                    Total.BackgroundColor = BaseColor.BLACK;
                    Total.BorderColor = BaseColor.BLACK;
                    Total.HorizontalAlignment = Element.ALIGN_CENTER;
                    Total.Padding = 5;
                    paymentTable.AddCell(Total);

                    var Data = new PdfPCell(new Phrase("Data", new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL, BaseColor.WHITE)));
                    Data.BackgroundColor = BaseColor.BLACK;
                    Data.BorderColor = BaseColor.BLACK;
                    Data.HorizontalAlignment = Element.ALIGN_CENTER;
                    Data.Padding = 5;
                    paymentTable.AddCell(Data);
                    foreach (var item in pagamentos)
                    {
                        paymentTable.AddCell(new PdfPCell(new Phrase(item.Data.ToString("MMMM").ToUpper())) { Padding = 10, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_LEFT });

                        paymentTable.AddCell(new PdfPCell(new Phrase(item.Propina.ToString("0.00"))) { Padding = 10, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_CENTER });

                        paymentTable.AddCell(new PdfPCell(new Phrase(item.Multa.ToString("0.00"))) { Padding = 10, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_CENTER });

                        paymentTable.AddCell(new PdfPCell(new Phrase((item.Propina + item.Multa).ToString("0.00"))) { Padding = 10, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_CENTER });

                        paymentTable.AddCell(new PdfPCell(new Phrase(item.Criado.ToString("dd/MM/yyyy"))) { Padding = 10, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_CENTER });

                    }
                    document.Add(paymentTable);
                    // Rodapé
                    BaseFont baseFont2 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    Font footerd = new Font(baseFont2, 12, Font.NORMAL);
                    Paragraph footer = new Paragraph("Data: " + DateTime.Now.ToString("dd/mm/yyyy"), footerd);
                    footer.SpacingBefore = 1;
                    footer.Alignment = Element.ALIGN_LEFT;
                    document.Add(footer);
                    // Feche o documento
                    document.Close();
                    if (File.Exists(relatorio))
                    {
                        System.Diagnostics.Process.Start(relatorio);
                    }
                }
                catch (Exception er)
                {
                    System.Windows.MessageBox.Show("Não foi possível gerar o Relatório: " + er.Message);
                }
            }

        }
        public static void RelatorioFeichoDia(HistoricoDia dia)
        {
            var arqNome = "Fecho do dia " + dia.Dia.Date.ToString("D");
            var relatorio = Salvar(arqNome + ".pdf");
            if (relatorio != null)
            {
                try
                {
                    var totaldia = gir.GetPagamentosDia(dia.Dia);
                    // Crie um novo documento
                    Document document = new Document();
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(relatorio, FileMode.Create));
                    document.Open();
                    // Defina uma fonte para o título
                    BaseFont baseFont = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    Font titleFont = new Font(baseFont, 14, Font.BOLD);
                    Font titleFont2 = new Font(baseFont, 14, Font.NORMAL);

                    // Logo
                    Image Logo = Image.GetInstance(Jupiter.Properties.Settings.Default.Logo);
                    Logo.ScaleToFit(50f, 50f);
                    Logo.Alignment = Element.ALIGN_CENTER;
                    document.Add(Logo);
                    // Título do recibo
                    Paragraph title = new Paragraph("FECHO DO DIA " + dia.Dia.ToString("D").ToUpper(), titleFont);
                    title.Alignment = Element.ALIGN_CENTER;
                    document.Add(title);

                    Font fontEscola = new Font(baseFont, 12, Font.NORMAL);
                    Paragraph escola = new Paragraph(Jupiter.Properties.Settings.Default.Escola.ToUpper(), fontEscola);
                    escola.Alignment = Element.ALIGN_CENTER;
                    document.Add(escola);
                    //// Tabela de pagamentos
                    Paragraph schoolInfo = new Paragraph();
                    schoolInfo.Alignment = Element.ALIGN_CENTER;
                    schoolInfo.SpacingBefore = 10f;
                    schoolInfo.Add("PAGAMENTOS");
                    document.Add(schoolInfo);
                    //// Tabela de pagamentos
                    PdfPTable paymentTable = new PdfPTable(6);
                    paymentTable.SpacingBefore = 20f;
                    paymentTable.WidthPercentage = 100f;

                    var padding = 3;
                    var aluno = new PdfPCell(new Phrase("ALUNO", new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.WHITE)));
                    aluno.BackgroundColor = BaseColor.BLACK;
                    aluno.BorderColor = BaseColor.BLACK;
                    aluno.HorizontalAlignment = Element.ALIGN_CENTER;
                    aluno.Padding = 5;
                    paymentTable.AddCell(aluno);

                    var celulaMes = new PdfPCell(new Phrase("MÊS", new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.WHITE)));
                    celulaMes.BackgroundColor = BaseColor.BLACK;
                    celulaMes.BorderColor = BaseColor.BLACK;
                    celulaMes.HorizontalAlignment = Element.ALIGN_CENTER;
                    celulaMes.Padding = 5;
                    paymentTable.AddCell(celulaMes);

                    var Propina = new PdfPCell(new Phrase("PROPINA", new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.WHITE)));
                    Propina.BackgroundColor = BaseColor.BLACK;
                    Propina.BorderColor = BaseColor.BLACK;
                    Propina.HorizontalAlignment = Element.ALIGN_CENTER;
                    Propina.Padding = 5;
                    paymentTable.AddCell(Propina);

                    var Multa = new PdfPCell(new Phrase("MULTA", new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.WHITE)));
                    Multa.BackgroundColor = BaseColor.BLACK;
                    Multa.BorderColor = BaseColor.BLACK;
                    Multa.HorizontalAlignment = Element.ALIGN_CENTER;
                    Multa.Padding = 5;
                    paymentTable.AddCell(Multa);

                    var Total = new PdfPCell(new Phrase("TOTAL", new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.WHITE)));
                    Total.BackgroundColor = BaseColor.BLACK;
                    Total.BorderColor = BaseColor.BLACK;
                    Total.HorizontalAlignment = Element.ALIGN_CENTER;
                    Total.Padding = 5;
                    paymentTable.AddCell(Total);

                    var Data = new PdfPCell(new Phrase("DATA", new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.WHITE)));
                    Data.BackgroundColor = BaseColor.BLACK;
                    Data.BorderColor = BaseColor.BLACK;
                    Data.HorizontalAlignment = Element.ALIGN_CENTER;
                    Data.Padding = 5;
                    paymentTable.AddCell(Data);

                    var font = new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.BLACK);
                    var fonttTotal = new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.BLACK);
                    foreach (var item in totaldia)
                    {
                        paymentTable.AddCell(new PdfPCell(new Phrase(item.NomeAluno, font)) { Padding = padding, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_LEFT });

                        paymentTable.AddCell(new PdfPCell(new Phrase(item.Data.ToString("MMMM").ToUpper(), font)) { Padding = padding, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_LEFT });

                        paymentTable.AddCell(new PdfPCell(new Phrase(item.Propina.ToString("0.00"), font)) { Padding = padding, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_CENTER });

                        paymentTable.AddCell(new PdfPCell(new Phrase(item.Multa.ToString("0.00"), font)) { Padding = padding, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_CENTER });

                        paymentTable.AddCell(new PdfPCell(new Phrase((item.Propina + item.Multa).ToString("0.00"), font)) { Padding = padding, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_CENTER });

                        paymentTable.AddCell(new PdfPCell(new Phrase(item.Criado.ToString("dd/MM/yyyy"), font)) { Padding = padding, VerticalAlignment = Element.ALIGN_CENTER, HorizontalAlignment = Element.ALIGN_CENTER });
                    }
                    document.Add(paymentTable);
                    Paragraph TOTAL = new Paragraph();
                    TOTAL.Alignment = Element.ALIGN_LEFT;
                    TOTAL.SpacingBefore = 5f;
                    TOTAL.Add(new Phrase("TOTAL: ", new Font(Font.FontFamily.HELVETICA, 12, Font.BOLD, BaseColor.BLACK)));
                    TOTAL.Add(new Phrase(dia.Total.ToString("C", cu), fonttTotal));
                    document.Add(TOTAL);
                    // Rodapé
                    BaseFont baseFont2 = BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
                    Font footerd = new Font(baseFont2, 10, Font.NORMAL);
                    Paragraph footer = new Paragraph("Data: " + DateTime.Now.Date.ToString("d"), footerd);
                    footer.Alignment = Element.ALIGN_LEFT;
                    document.Add(footer);
                    // Feche o documento
                    document.Close();
                    if (File.Exists(relatorio))
                    {
                        System.Diagnostics.Process.Start(relatorio);
                    }
                }
                catch (Exception er)
                {
                    System.Windows.MessageBox.Show("Não foi possível gerar o Relatório: " + er.Message);
                }
            }

        }
        public static void CartaoAluno(Aluno aluno)
        {
            var arqNome = "Cartão de " + aluno.Nome + " Ano letivo " + aluno.Ano + ".pdf";
            var cartao = Salvar(arqNome);
            if (cartao != null)
            {
                try
                {
                    var fontSize = new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL, BaseColor.BLACK);
                    var fontSize2 = new Font(Font.FontFamily.HELVETICA, 8, Font.NORMAL, BaseColor.BLACK);
                    var sp = -5;
                    Document document = new Document(PageSize.A6);
                    PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(cartao, FileMode.Create));
                    document.SetPageSize(PageSize.A6.Rotate());
                    document.Open();
                    // Logotipo de Angola
                    Image angolaLogo = Image.GetInstance(Angola);
                    angolaLogo.ScaleToFit(30f, 30f);
                    angolaLogo.Alignment = Element.ALIGN_CENTER;
                    document.Add(angolaLogo);
                    // Título
                    Paragraph title = new Paragraph();
                    title.Alignment = Element.ALIGN_CENTER;
                    title.Add(new Phrase("REPÚBLICA DE ANGOLA", fontSize));
                    title.SpacingAfter = 0;
                    document.Add(title);
                    // Informações do governo
                    Paragraph governmentInfo = new Paragraph();
                    governmentInfo.Alignment = Element.ALIGN_CENTER;
                    governmentInfo.Add(new Phrase("GOVERNO DA PROVÍNCIA DE LUANDA", fontSize));
                    governmentInfo.SpacingBefore = sp;
                    document.Add(governmentInfo);
                    // Número da escola
                    Paragraph schoolInfo = new Paragraph();
                    schoolInfo.Alignment = Element.ALIGN_CENTER;
                    schoolInfo.Add(new Phrase(Jupiter.Properties.Settings.Default.Escola, fontSize2));
                    schoolInfo.SpacingBefore = sp;
                    document.Add(schoolInfo);
                    // Título do comprovativo
                    Paragraph receiptTitle = new Paragraph();
                    receiptTitle.Alignment = Element.ALIGN_CENTER;
                    receiptTitle.Add(new Phrase("CARTÃO DE ESTUDANTE", new Font(Font.FontFamily.HELVETICA, 8, Font.BOLD, BaseColor.BLACK)));
                    receiptTitle.SpacingBefore = sp;
                    document.Add(receiptTitle);

                    // FOTO ALUNO
                    Image FotoAluno = Image.GetInstance(aluno.Foto);
                    FotoAluno.ScaleToFit(85f, 85f);
                    var px = PageSize.A6.Width;
                    FotoAluno.SetAbsolutePosition(px + 10, 80);
                    document.Add(FotoAluno);
                    // Informações do aluno
                    Paragraph br = new Paragraph();
                    br.Add("\n");
                    document.Add(br);
                    string[] rotulos = { "Nome ", "Nº ", "Classe ", "Sala ", "Ano Letivo " };

                    // Dados (deixe em branco para preenchimento)
                    string[] dados = { aluno.Nome,aluno.Numero.ToString(), aluno.Classe.ToString() + "ª", aluno.Sala.ToString(), aluno.Ano.ToString() };

                    for (int i = 0; i < rotulos.Length; i++)
                    {
                        var route = new iTextSharp.text.Paragraph(rotulos[i], new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.BLACK));
                        route.Add(new Phrase(dados[i], new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.GRAY)));
                        document.Add(route);
                    }
                    var EMITIDO = new iTextSharp.text.Paragraph("Data: ", new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.BLACK));
                    EMITIDO.Add(new Phrase(DateTime.Now.ToString("dd/mm/yy"), new Font(Font.FontFamily.HELVETICA, 10, Font.NORMAL, BaseColor.GRAY)));
                    document.Add(EMITIDO);
                    // Gere o código de barras
                    BarcodeWriter barcodeWriter = new BarcodeWriter();
                    EncodingOptions options = new EncodingOptions
                    {
                        Width = 300, // Largura do código de barras
                        Height = 100 // Altura do código de barras
                    };
                    barcodeWriter.Options = options;
                    barcodeWriter.Format = BarcodeFormat.CODE_128;
                    var code = aluno.ID.ToString() + "-" + aluno.Ano.ToString();
                    var barcodeBitmap = barcodeWriter.Write(code);
                    // Adicione o código de barras ao documento
                    iTextSharp.text.Image barcodeImage = iTextSharp.text.Image.GetInstance(barcodeBitmap, BaseColor.BLACK);
                    barcodeImage.ScaleAbsolute(135f, 30f);
                    barcodeImage.SetAbsolutePosition(PageSize.A6.Width - 15, 30);
                    document.Add(barcodeImage);

                    document.Close();

                    if (File.Exists(cartao))
                    {
                        System.Diagnostics.Process.Start(cartao);
                    }
                }
                catch (Exception er)
                {
                    System.Windows.MessageBox.Show("Não foi possível gerar o Cartão do Aluno: " + er.Message);
                }
            }

        }
        public static void CodeBarraAluno(Aluno aluno)
        {
            var local = SalvarCode("Código de Barra do " + aluno.Nome + ".jpg");
            if (local != null)
            {
                try
                {
                    // Gere o código de barras
                    BarcodeWriter barcodeWriter = new BarcodeWriter();
                    EncodingOptions options = new EncodingOptions
                    {
                        Width = 300, // Largura do código de barras
                        Height = 100 // Altura do código de barras
                    };
                    barcodeWriter.Options = options;
                    barcodeWriter.Format = BarcodeFormat.CODE_128;
                    var code = aluno.ID.ToString() + "-" + aluno.Ano.ToString();
                    var barcodeBitmap = barcodeWriter.Write(code);
                    // SAALVAR
                    barcodeBitmap.Save(local);
                }
                catch (Exception er)
                {
                    System.Windows.MessageBox.Show("Não foi possível gerar Código de Barra: " + er.Message);
                }
            }

        }
        private static string SalvarCode(string nome)
        {
            var sv = new SaveFileDialog();
            sv.Filter = "JPG|*.jpg";
            sv.FileName = nome;
            sv.InitialDirectory = doc.FullName;
            var result = sv.ShowDialog();
            if (result == DialogResult.OK)
            {
                return sv.FileName;
            }
            return null;
        }
        private static string Salvar(string nome)
        {
            var sv = new SaveFileDialog();
            sv.Filter = "PDF|*.pdf";
            sv.FileName = nome;
            sv.InitialDirectory = doc.FullName;
            var result = sv.ShowDialog();
            if (result == DialogResult.OK)
            {
                return sv.FileName;
            }
            return null;
        }
    }
}
