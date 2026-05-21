Sistema de Compra com Cupom de Desconto
Sistema simples de compra em C# via console, com suporte a cupom de desconto de 20% e cálculo de frete baseado nas dimensões do produto.

Funcionalidades

Cadastro do produto e seu preço
Aplicação de cupom de desconto de 20% para compras acima de R$ 1.500,00
Cálculo de frete (R$ 150,00) baseado nas dimensões do produto
Frete grátis para produtos com largura, altura e comprimento todos abaixo de 150 cm
Confirmação de compra pelo usuário


Fluxo do Sistema
Informe o produto e o preço
        │
        ▼
   Preço >= R$ 1.500?
   ├── Não → Encerra
   └── Sim → Deseja usar cupom?
              ├── Não → Cobra preço + frete e encerra
              └── Sim → Informe dimensões (largura, altura, comprimento)
                         │
                         ▼
                  Alguma dimensão >= 150 cm?
                  ├── Sim → Frete R$ 150,00 cobrado
                  │         Confirma compra? → Aplica 20% desconto + frete
                  └── Não → Frete grátis
                            Confirma compra? → Aplica 20% desconto

Regras de Negócio
CondiçãoDescontoFretePreço < R$ 1.500❌ Sem descontoR$ 150,00Preço ≥ R$ 1.500, sem cupom❌ Sem descontoR$ 150,00Preço ≥ R$ 1.500, com cupom, dimensão ≥ 150 cm✅ 20%R$ 150,00Preço ≥ R$ 1.500, com cupom, todas dimensões < 150 cm✅ 20%Grátis

Como Executar
Pré-requisitos

.NET SDK instalado

Passos
bash# Clone o repositório
git clone https://github.com/Samoraaa/sistema-compra-cupom.git

# Acesse a pasta do projeto
cd sistema-compra-cupom

# Execute o projeto
dotnet run

Exemplo de Uso
qual é o produto que deseja comprar
> Notebook

qual o preço do produto
> 2000

você deseja utilizar um cupom?
> sim

qual a largura?
> 40
qual a altura?
> 5
qual o comprimento?
> 30

você possui o frete gratis - deseja realizar a compra?
 Sim/Não
> sim

Compra realizada, seu valor final foi: 1600

Tecnologias

Linguagem: C#
Plataforma: .NET (Console Application)
IDE recomendada: JetBrains Rider ou Visual Studio
