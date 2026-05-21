int largura, comprimento, altura;
string cupom, produto;
double preço, desconto, preço_final, frete;
string usar_cupom, realizar_compra;
frete = 150.00;
Console.WriteLine("qual é o produto que deseja comprar");
produto = Console.ReadLine();
Console.WriteLine("qual o preço do produto");
preço = Convert.ToSingle(Console.ReadLine());
if (preço >= 1500.00)
{
    Console.WriteLine("você deseja utilizar um cupom?");
    usar_cupom = Convert.ToString(Console.ReadLine());
    if (usar_cupom == "sim")
    {
        Console.WriteLine("qual a largura?");
        largura = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("qual a altura?");
        altura = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("qual o comprimento?");
        comprimento = Convert.ToInt32(Console.ReadLine());
        if (comprimento >= 150 || largura >= 150 || altura >= 150)
        {
            Console.WriteLine("você não possui o frete gratis - deseja realizar a compra?\n Sim/Não");
            realizar_compra = Convert.ToString(Console.ReadLine());
            if (realizar_compra == "sim")
            {
                desconto = preço * 0.20;
                preço_final = preço - desconto + frete;
                Console.WriteLine("Compra realizada, seu valor final foi: " + preço_final);
            }
            else if (realizar_compra == "não")
            {
                Console.WriteLine("compra finalizada");
            }
        }
        else if (comprimento < 150 || largura < 150 || altura < 150)
        {
            Console.WriteLine("você possui o frete gratis - deseja realizar a compra?\n Sim/Não");
            realizar_compra = Convert.ToString(Console.ReadLine());
            if (realizar_compra == "sim")
            {
                desconto = preço * 0.20;
                preço_final = preço - desconto;
                Console.WriteLine("Compra realizada, seu valor final foi: " + preço_final);
            }
            else if (realizar_compra == "não")
            {
                Console.WriteLine("compra finalizada");
            }
        }
    }
    else if (usar_cupom == "não")
    {
        Console.WriteLine("compra finalizada, o valor final foi " + (preço+frete));
    }
}

