using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*ideias:
 * separar as letras que ja foram escritas mas nao contem na palavra específica. Podem ficar em uma caixa de texto do lado e caso seja usada novamente, mostrar a mensagem de que a letra ja foi usada
 * */

namespace Projeto_Termooo
{
    public partial class Form1 : Form
    {
        //RichTextBox richTextBox1 = new RichTextBox();
        public Form1()
        {
            InitializeComponent();
            rtbEscrever.Visible = false; //tira o espaço de escrever antes de clicar em novo jogo
            btnEnviar.Visible = false;
        }
        private string[] palavras = { 
 "sagaz", "amago", "negro", "exito", "mexer", "termo", "senso", "nobre", "algoz", "afeto",
 "plena", "etica", "mutua", "tenue", "sutil", "vigor", "aquem", "porem", "audaz", "fazer",
 "sanar", "seçao", "inato", "assim", "cerne", "ideia", "fosse", "desde", "poder", "moral",
 "torpe", "muito", "honra", "justo", "futil", "gozar", "anexo", "razao", "quiça", "etnia",
 "sobre", "icone", "tange", "sonho", "egide", "lapso", "mutuo", "expor", "haver", "amigo",
 "habil", "casal", "tempo", "seara", "pesar", "posse", "avido", "porra", "entao", "boçal",
 "dengo", "genro", "coser", "ardil", "corja", "causa", "prole", "paria", "detem", "dizer",
 "tenaz", "dever", "digno", "saber", "crivo", "obice", "apice", "ansia", "graça", "animo",
 "ceder", "brado", "orgia", "gleba", "comum", "assaz", "atroz", "culto", "sendo", "temor",
 "mundo", "pauta", "censo", "fugaz", "denso", "valha", "cozer", "ainda", "nenem", "vicio",
 "forte", "estar", "reves", "vulgo", "pudor", "regra", "dogma", "louco", "criar", "banal",
 "impor", "pifio", "tenro", "desse", "apraz", "round", "jeito", "saude", "ordem", "atras",
 "pedir", "reaça", "merce", "clava", "usura", "viril", "juizo", "sabio", "prosa", "servo",
 "manso", "ontem", "feliz", "presa", "coisa", "homem", "falar", "cunho", "forma", "devir",
 "fluir", "afago", "ebrio", "meiga", "xibiu", "plato", "serio", "vendo", "mesmo", "guisa",
 "limbo", "pleno", "visar", "magoa", "temer", "heroi", "cisma", "acaso", "bruma", "puder",
 "lugar", "valor", "exodo", "obvio", "gerar", "afins", "impio", "obter", "matiz", "certo",
 "crise", "senil", "praxe", "posso", "havia", "venia", "fluxo", "enfim", "ritmo", "tedio",
 "alibi", "todos", "tomar", "garbo", "abrir", "uniao", "reter", "pulha", "parvo", "valia",
 "visao", "vital", "grato", "favor", "facil", "bravo", "vivaz", "falso", "laico", "parco",
 "prumo", "genio", "ameno", "olhar", "possa", "reles", "obito", "burro", "levar", "prime",
 "tesao", "casta", "tecer", "legal", "selar", "anelo", "fator", "ranço", "citar", "rogar",
 "farsa", "façam", "noçao", "adiar", "morte", "achar", "coeso", "cabal", "cisao", "epico",
 "sabia", "nicho", "falta", "fardo", "ouvir", "imune", "força", "sinto", "ativo", "gente",
 "viver", "exato", "noite", "haste", "brega", "amplo", "lavra", "sulco", "passo", "sonso",
 "dubio", "cesta", "labor", "tendo", "gesto", "revel", "leigo", "sesta", "unico", "deter",
 "vemos", "arduo", "atuar", "calma", "feixe", "vadia", "rever", "otica", "humor", "ciume",
 "tende", "igual", "pobre", "hiato", "sonsa", "toada", "ponto", "debil", "ideal", "velho",
 "outro", "vacuo", "claro", "linda", "carma", "ambos", "terno", "remir", "fusao", "varao",
 "cauda", "probo", "ajuda", "leito", "senao", "advem", "doido", "marco", "fonte", "jovem",
 "horda", "inata", "capaz", "xeque", "relva", "tenra", "algum", "ficar", "caçar", "velar",
 "apoio", "terra", "serie", "anuir", "farao", "rigor", "vimos", "dorso", "verso", "lider",
 "vazio", "tanto", "entre", "botar", "coçar", "frase", "cruel", "massa", "prece", "virus",
 "pouco", "moçao", "ambas", "morar", "signo", "coesa", "peste", "sente", "casto", "fauna",
 "covil", "preso", "credo", "minha", "feito", "faina", "raiva", "furor", "lazer", "docil",
 "ciclo", "impar", "torço", "vetor", "flora", "maior", "corno", "chata", "papel", "arido",
 "brisa", "aceso", "beata", "trama", "vulto", "houve", "pegar", "breve", "manha", "adeus",
 "liame", "birra", "setor", "vasto", "salvo", "blase", "senda", "seita", "banzo", "ardor",
 "nossa", "morro", "livro", "pecha", "atomo", "visse", "prado", "reger", "peixe", "antro",
 "meses", "avaro", "segue", "comer", "prono", "plano", "ocaso", "saiba", "rezar", "chuva",
 "sorte", "ancia", "aureo", "saida", "otimo", "alias", "pajem", "nunca", "foder", "junto",
 "acima", "chulo", "mudar", "carro", "fitar", "opçao", "serao", "sinal", "jazia", "fruir",
 "parar", "seria", "treta", "fugir", "puxar", "bando", "naçao", "motim", "gerir", "prazo",
 "andar", "grupo", "tosco", "leite", "norma", "alude", "epoca", "sinha", "brava", "lenda",
 "rapaz", "tenso", "parte", "exame", "aviao", "idolo", "arcar", "campo", "tirar", "psico",
 "reino", "venal", "soldo", "malta", "praga", "quota", "virao", "vilao", "sumir", "anais",
 "aonde", "exijo", "corpo", "logro", "agora", "pompa", "traga", "preto", "voraz", "fixar",
 "antes", "indio", "quase", "cheio", "risco", "praia", "certa", "filho", "turva", "nodoa",
 "solto", "copia", "oasis", "turba", "alado", "apego", "texto", "caixa", "messe", "estao",
 "doido", "grave", "prova", "parva", "acesa", "perda", "verve", "nivel", "apelo", "ligar",
 "atrio", "pardo", "tocar", "trupe", "fenda", "lindo", "dessa", "viria", "sabia", "livre",
 "retem", "conta", "coito", "alçar", "verbo", "opaco", "navio", "aurea", "ficha", "fraco",
 "afora", "etico", "astro", "faixa", "elite", "parca", "supra", "glosa", "jirau", "autor",
 "verba", "cioso", "lidar", "mente", "oxala", "tinha", "firme", "festa", "grata", "fatos",
 "magia", "fatal", "bater", "calda", "reses", "cousa", "prive", "junco", "pique", "irmao",
 "deixa", "pagao", "molho", "salve", "douto", "macio", "abriu", "manha", "torso", "turvo",
 "supor", "light", "atual", "bicho", "posto", "igneo", "asilo", "orfao", "extra", "rouca",
 "caber", "judeu", "curso", "sarça", "sexta", "vezes", "locus", "besta", "ruina", "pisar",
 "desta", "zelar", "radio", "video", "longe", "abuso", "porta", "canon", "paira", "combo",
 "ereto", "finda", "bioma", "culpa", "vinha", "vosso", "agudo", "feudo", "menos", "baixo",
 "facto", "tetra", "drops", "urgia", "bonus", "advir", "cutis", "surja", "estio", "meigo",
 "traço", "super", "sitio", "autos", "tento", "gosto", "rumor", "facho", "suave", "calao",
 "cocho", "amena", "pilar", "museu", "nosso", "clean", "turma", "lasso", "geral", "acola",
 "chama", "açoes", "optar", "pifia", "medir", "louça", "boato", "mosto", "podio", "lapis",
 "local", "penta", "hobby", "rubro", "crime", "letal", "pacto", "folga", "ponha", "cacho",
 "refem", "drama", "cover", "brabo", "aroma", "hoste", "vigia", "poema", "vetar", "fazia",
 "pasmo", "feroz", "mesma", "movel", "açude", "rival", "finjo", "troça", "monte", "axila",
 "peito", "golpe", "aluno", "metie", "avida", "ecoar", "pareo", "coral", "julia", "riste",
 "teste", "forum", "lesse", "liçao", "daqui", "plebe", "sucia", "forem", "monge", "clima",
 "chato", "carta", "poeta", "ebano", "escol", "cetro", "macro", "swing", "piada", "passa",
 "falha", "sarau", "viram", "venha", "ateia", "verde", "tacha", "briga", "conto", "calmo",
 "cargo", "farta", "legua", "atimo", "fruto", "roupa", "busca", "perco", "berro", "tarde",
 "plaga", "idoso", "broxa", "plumo", "aviso", "artur", "tribo", "chefe", "vento", "virar",
 "corso", "grama", "arado", "civil", "surto", "assar", "estro", "seixo", "bruta", "recem",
 "catre", "traje", "ornar", "saldo", "nuvem", "beijo", "deste", "impia", "fosso", "troca",
 "pedra", "deram", "trato", "vedar", "arfar", "depor", "tiçao", "giria", "porte", "irado",
 "uteis", "manga", "casar", "grota", "canso", "ambar", "manga", "silvo", "unica", "cifra",
 "pasma", "bença", "gabar", "bazar", "amado", "sosia", "tutor", "magna", "vazao", "regio",
 "rural", "tiver", "pavor", "laudo", "bruto", "perto", "segar", "itens", "renda", "bucho",
 "midia", "troco", "tchau", "amiga", "nesse", "jejum", "vagar", "minar", "molde", "odiar",
 "inter", "viado", "clero", "lesto", "vadio", "feita", "fossa", "orgao", "meche", "sotao",
 "areia", "pomar", "aviar", "negar", "cenho", "cinto", "largo", "paiol", "lesao", "ileso",
 "canto", "rocha", "pinho", "horto", "visto", "pugna", "ruido", "bolsa", "proto", "podar",
 "inves", "ufano", "marca", "urdir", "guria", "densa", "vista", "morfo", "civel", "dubia",
 "jogar", "close", "frota", "vasta", "mocho", "penso", "mamae", "xucro", "bunda", "bulir",
 "culta", "piche", "umido", "chula", "peita", "amada", "cheia", "ubere", "linha", "esgar",
 "stand", "canil", "resto", "varoa", "apear", "misto", "demao", "fazes", "manto", "natal",
 "monta", "narco", "fundo", "findo", "campa", "barao", "gemer", "agape", "nessa", "tenha",
 "chaga", "jazer", "simio", "retro", "album", "mover", "cerca", "preço", "ardis", "venho",
 "folia", "cosmo", "polis", "santo", "labia", "velha", "volta", "punha", "seiva", "ferpa",
 "alamo", "matar", "verao", "sabor", "banto", "letra", "porca", "sigla", "calça", "rente",
 "ceita", "louro", "firma", "barro", "nesta", "salva", "etapa", "trago", "audio", "arroz",
 "troço", "axial", "redor", "tumba", "limpo", "torna", "miope", "final", "coevo", "bolso",
 "solta", "logos", "enjoo", "lousa", "coroa", "ousar", "lutar", "queda", "baixa", "fugiu",
 "sinta", "corar", "zumbi", "mimar", "farol", "obtem", "veloz", "neste", "cacto", "folha",
 "nacar", "burra", "reler", "dança", "fatuo", "longo", "penca", "vazia", "vario", "forro",
 "macho", "quite", "justa", "mania", "farto", "bedel", "sugar", "puido", "salmo", "repor",
 "lucro", "staff", "ultra", "refil", "calor", "chave", "gueto", "subir", "viger", "passe",
 "custo", "sexto", "urgir", "logia", "sadio", "mimos", "todas", "harem", "hifen", "valer",
 "versa", "calvo", "usual", "lento", "socio", "mouro", "cardo", "merda", "redea", "ardua"};
        private string palavra;
        private int k;
        private int j;
        private int tentativas;
        private string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ";
        private bool resposta = true;
  
        private void btnNovoJogo_Click(object sender, EventArgs e) //botão de novo jogo, pega uma nova palavra e limpa o antigo
        {
            tentativas = 0;
            rtbMostrar.Clear();
            Random r = new Random();
            int n = r.Next(0, palavras.Length);
            palavra = palavras[n].ToUpper();
            rtbEscrever.Visible = true;
            btnEnviar.Visible = true;
            rtbEscrever.Focus();
        }
        private void btnEnviar_Click(object sender, EventArgs e) //executa métodos depois de clicar no botão
        {
            checaExcecao(rtbEscrever.Text.ToUpper()); //verifica exceção, se tiver algum erro na palavra(resposta = false) não roda o resto do programa
            if (resposta == true)
            {
                escrever();
                checarLetraAmarela();
                checarLetraVerde();
                rtbMostrar.SelectAll();
                rtbMostrar.SelectionAlignment = HorizontalAlignment.Center;
                if (k == 5)
                {
                    MessageBox.Show($"PARABÉNS, VOCÊ ACERTOU!!! A PALAVRA ERA: \"{palavra}\"", "You Win", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    rtbEscrever.Visible = false;
                    btnEnviar.Visible = false;
                }
                else if (tentativas == 5)
                {
                    MessageBox.Show($"VOCÊ PERDEU!! A PALAVRA ERA: \"{palavra}\", QUEM SABE NA PRÓXIMA...", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    rtbEscrever.Visible = false;
                    btnEnviar.Visible = false;
                }
            }

        }
        private void escrever()
        {
            rtbMostrar.Text += rtbEscrever.Text.ToUpper() + "\n"; //a quebra de linha adiciona um espaço em branco depois da palavra
        }
        private void checarLetraVerde()
        {
            k = 0;
            j = 0;
            for (int i = 0; i < rtbMostrar.TextLength - 1; i++) //checa se as posições estão certas
            {
                if (j == 5)
                {
                    k = 0;
                    j = 0;
                    i++; //precisa adicionar mais um, pois no fim há um espaço em branco por conta da quebra de linha

                }

                if (palavra[j] == rtbMostrar.Text[i])
                {
                    k++;
                    rtbMostrar.Select(i, 1); //seleciona as letras a partir de "i" e a quantidade 1
                    rtbMostrar.SelectionColor = Color.Green; //coloca as letras selecionadas em verdes
                }
                j++;
            }
        }

        private string retiraLetrasCertas(int n) //retirar as letras verdes da palavra
        {
            string retirarLetras = "";
            for (int i = 0; i < palavra.Length; i++)
            {
               if (rtbMostrar.Text[i+n] != palavra[i])
                    retirarLetras += palavra[i];
            }
            return retirarLetras;
        }

        private void checarLetraAmarela()
        {
            string palavraTestada = "";
            string letrasNaoVerdes = "";
            for (int i = 0; i < rtbMostrar.TextLength - 1; i++) //checa todo o vetor com as palavras
            {
                if (i % 6 == 0)
                {
                    palavraTestada = rtbMostrar.Text.Substring(i, 5); //pega a palavra da linha colocada pelo usuário
                    letrasNaoVerdes = retiraLetrasCertas(i); //pega as letras da palavra que não foram encontradas no local correto

                    for (int u = 0; u < letrasNaoVerdes.Length; u++)
                    {
                        for (int v = 0; v < palavraTestada.Length; v++)
                        {
                            if (letrasNaoVerdes[u] == palavraTestada[v])
                            {
                                rtbMostrar.Select(i + v, 1); //seleciona as letras a partir de "v"(posicao da palavra testada) e "i"(a linha da palavra testada) e a quantidade 1
                                rtbMostrar.SelectionColor = Color.DarkOrange; //coloca as letras selecionadas em amarelo
                                break;
                            }
                        }
                    }

                }

            }
            rtbEscrever.Clear();//limpar e focar no txtBox depois de digitar uma palavra certa
            rtbEscrever.Focus();
        }

        private void checaExcecao(string texto) // metodo para verificar se a palavra foi digitada corretamente
        {
            if (texto != "" || texto.Length != 0)
            {
                for (int i = 0; i < texto.Length; i++)
                {
                    if (alfabeto.IndexOf(texto[i]) == -1)
                    {
                        MessageBox.Show("Somente letras e sem espaços em branco!!\nDigite novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        rtbEscrever.Clear();//limpar e focar no txt depois de digitar uma palavra errada, ou seja, outra palavra, mesma tentativa
                        rtbEscrever.Focus();
                        resposta = false;
                        break;
                    }
                    else if (texto.Length != 5)
                    {
                        resposta = false;
                        MessageBox.Show("Somente palavras com 5 letras!!\nDigite novamente", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                    }
                    else
                    {
                        resposta = true;
                    }
                }
                if (resposta == true) // incrementa em tentativas, se estiver tudo ok com a palavra digitada
                    tentativas++;
            }
            else
            {
                MessageBox.Show("Digite uma palavra!!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                resposta = false;
            }

        }
        private void btnVoltar1_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            frm2.ShowDialog(); //abre a janela do forms2 (tela inicial)
            Hide(); //esconde a janela atual
            Close();
        }

        private void rtbEscrever_KeyUp(object sender, KeyEventArgs e)
        {
                if ((Keys)e.KeyCode == Keys.Enter)
                {
                    btnEnviar.PerformClick();

                }
        }
    }
}
