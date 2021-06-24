## **Projeto da Disciplina de Desenvolvimento de Aplicações**

## Sistema *Bookids*

*Link Github: https://github.com/ArturMarceloVascoIPL/projetoDesenvolvimentoAplicacoes_2020.2021*

***

### **TeSP de Programação de Sistemas de Informação**

#### **Instituto Politécnico de Leiria 2020/2021**

***

**Grupo:**

**2201115** Artur Quaresma

**2200428** Marcelo Marques

**2200426** Vasco Silva

***

**Objetivo:**

Criar um sistema para a gestão de uma loja de venda de brinquedos e outros acessórios para crianças e realizacao de eventos em associação com escolas e outros colaboradores.

**Como Utilizar:**

Utilizar o *VS2019* (**Visual Studio 19**):

Para **instalar as extensões/*frameworks* necessárias** e correr o programa;

É necessário também verificar que tem os ***Workloads* corretos instalados**, que será o **"*Data storage and processing*"**que se encontra na *tab* de *Other Toolsets* no instalador do Visual Studio;

Para a **criação da base de dados**, será criada com um ficheiro automaticamente gerado pelo modelo, o "DataBaseModel.edmx.sql", que se utiliza com o VS2019 para correr o ficheiro, ligado ao servidor pelo ".\SQLEXPRESS";

A seguir, correr o "DBUpdateDecimalValueType.sql", que vai atualizar os campos de tipo
*DECIMAL* para aceitarem corretamente 2 números decimais como pretendido.

