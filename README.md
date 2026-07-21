# Cozinha da Dona Maria

O Cozinha da Dona Maria é um sistema desenvolvido em C# para auxiliar no gerenciamento de receitas e ingredientes de uma cozinha.

A aplicação permite cadastrar ingredientes, definir suas unidades de medida e criar receitas utilizando esses ingredientes.

Além disso, o sistema possibilita consultar quais receitas podem ser preparadas a partir de um ingrediente específico, facilitando a organização e o planejamento da produção.

# Tecnologias Utilizadas

* C#
* .NET
* Windows Forms
* SQL Server 
* Visual Studio

# Funcionalidades

* Cadastro de ingredientes
* Cadastro de unidades de medida
* Cadastro de receitas
* Associação de ingredientes às receitas
* Consulta de receitas por ingrediente
* Pesquisa rápida de ingredientes
* Gerenciamento das informações cadastradas

# Principais Módulos

## Ingredientes

Permite cadastrar todos os ingredientes utilizados nas receitas, armazenando informações como:

* Nome do ingrediente
* Unidade de medida
* Descrição

## Unidades de Medida

O sistema permite definir a unidade de medida utilizada por cada ingrediente, como:

* Quilograma (kg)
* Grama (g)
* Litro (L)
* Mililitro (mL)
* Unidade (un)

## Receitas

Cada receita pode possuir diversos ingredientes cadastrados, permitindo organizar corretamente sua composição.

São armazenadas informações como:

* Nome da receita
* Ingredientes utilizados
* Unidade de medida de cada ingrediente

## Consulta por Ingrediente

Uma das principais funcionalidades do sistema é a pesquisa de ingredientes.

Ao selecionar um ingrediente, o sistema apresenta automaticamente todas as receitas que utilizam esse ingrediente, facilitando a consulta e o planejamento do preparo.

# Estrutura do Projeto

CozinhaDaDonaMaria/
│
├── Forms/
├── Models/
├── Services/
├── Properties/
├── bin/
├── obj/
└── README.md

# Como Executar o Projeto

## 1. Clone o repositório

bash
git clone https://github.com/sMEduarda/CozinhaDonaMaria.git

## 2. Abra a solução

Abra o arquivo `.sln` utilizando o Visual Studio.

## 3. Configure o Banco de Dados

Caso o projeto utilize SQL Server:

* Crie o banco de dados.
* Atualize a *Connection String* com as configurações do seu ambiente.

## 4. Execute a aplicação

Pressione F5 ou clique em Start no Visual Studio.

# Fluxo de Utilização

1. Cadastre as unidades de medida.
2. Cadastre os ingredientes.
3. Cadastre as receitas.
4. Associe os ingredientes às receitas.
5. Pesquise um ingrediente.
6. Visualize todas as receitas que utilizam o ingrediente selecionado.

# Conceitos Aplicados

* Programação Orientada a Objetos (POO)
* Windows Forms
* CRUD
* Relacionamento entre entidades
* Modelagem de Banco de Dados
* Pesquisa de Dados
* Reutilização de Ingredientes em Receitas

Projeto acadêmico desenvolvido com o objetivo de aplicar conceitos de programação orientada a objetos, banco de dados e gerenciamento de receitas culinárias.
