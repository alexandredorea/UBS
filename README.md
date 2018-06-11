# Desafio: Unidades Básicas de Saúde



## Introdução

Este repositório é uma adaptação de um teste/desafio realizado como parte de um processo seletivo ao qual participei para Vaga de Desenvolvedor .NET em uma empresa.

Além da adaptação, foram adicionados conceitos concernentes a gestão de projetos, gerência de configuração, analise de sistemas entre outros requisitos.

## Cenário

Você trabalha no Cia. de Processamento de Dados do seu Estado. O responsável pela gestão dos novos produtos, decidiu que chegou a hora de implementar uma nova WebAPI que permita consultar todas as Unidades Básicas de Saúde do país.

Sua função é implementar uma WebAPI que permita consultar e listar as 5 Unidades Básicas de Saúde (UBSs) mais próximas das coordenadas de latitude e longitude fornecidas como parâmetro, e, o resultado deve ser apresentado de forma ordenada pela Avaliação de Desempenho de cada uma dessas unidades da mais bem avaliada para a menor avaliada.

## Arquitetura

A estrutuda da aplicações está divida nas seguintes camadas:


| Camada         | Descrição                                                                                                    | Documentos    |
|----------------|--------------------------------------------------------------------------------------------------------------|---------------|
| Apresentação   | N/A                                                                                                          | N/A           |
| Serviço        | Camada de Web API que deverá expor um método HTTP GET para retornar os dados solicitados no desafio          | [Requisito]() |
| Aplicação      | Camada de lógica de aplicação, que deve ser consumida pela Web API com as regras de negócio do exercício     | [Requisito]() |
| Domínio        | Camada do domínio (entidades/modelos) de aplicação com seus atributos e metodos                              | [Requisito]() |
| Infraestrutura | Camada que possui o acesso a dados, onde a carga e disponibilização dos dados da aplicação são implementadas | [Requisito]() |


## Recursos utilizados no desenvolvimento da aplicação:

|Recurso                                   |Documento                         |Download          |
|------------------------------------------|----------------------------------|------------------|
|Visual Studio 2017                        |[Guia][GuiaVS2017]                |[IDE][IDEVS2017]  |
|Linguagem C#                              |[Guia][GuiaCSharp]                |N/A               |
|Conceitos de DDD (Domain Driven Design)   |[Tutorial][GuiaDDD]               |N/A               |
|ASP.NET Core 2.0                          |[Guia][GuiaASPNetCore]            |N/A               |
|Entity Framework Core 2.0                 |[Guia][GuiaEntityCore]            |N/A               |
|Repositório de Dados (Repository Pattern) |[Tutorial][GuiaRepositoryPattern] |N/A               |
|Migration                                 |[Guia][GuiaMigrations]            |N/A               |
|SQL Server 2017                           |[Guia][GuiaSQL2017]               |[IDE][IDESQL2017] |

## Andamento do Projeto

Para se ter uma ideia do andamento do projeto [clique aqui]() e tenha acesso ao Quadro Atividades para verificar a Lista das *Tasks*.

## Ainda tem perguntas ou sugestão de melhoria?

Sinta-se à vontade em abrir um [issue](https://github.com/alexandredorea/UBS/issues) ou [pull request](https://github.com/alexandredorea/UBS/pulls).

## FAQ sobre esta entrevista

Para ter acesso ao FAQ [clique aqui]().


[//]: # (Links de referências para o quadro de recursos utilizados)

[GuiaVS2017]: <https://docs.microsoft.com/pt-br/visualstudio/ide/>
[IDEVS2017]: <https://www.visualstudio.com/pt-br/downloads/>
[GuiaCSharp]: <https://docs.microsoft.com/pt-br/dotnet/csharp/>
[GuiaDDD]: <http://www.agileandart.com/2010/07/16/ddd-introducao-a-domain-driven-design/>
[GuiaASPNetCore]: <https://docs.microsoft.com/pt-br/dotnet/core/>
[GuiaEntityCore]: <https://docs.microsoft.com/pt-br/dotnet/framework/>
[GuiaRepositoryPattern]: <https://code.msdn.microsoft.com/windowsdesktop/Implementando-Repositrio-aabcdbce>
[GuiaMigrations]: <https://docs.microsoft.com/pt-br/ef/core/managing-schemas/migrations/>
[GuiaSQL2017]: <https://docs.microsoft.com/pt-br/sql/sql-server/sql-server-technical-documentation>
[IDESQL2017]: <https://www.microsoft.com/pt-br/sql-server/sql-server-downloads>
