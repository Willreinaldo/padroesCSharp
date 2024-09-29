# Projetos de Padrões de Design em C#

Este repositório contém exemplos de implementação de padrões de design estruturais em C#.

## Requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) (versão 6.0 ou superior)

# Padrões de Design em C#

Este repositório contém exemplos de padrões de design estruturais implementados em C#. Cada padrão é demonstrado através de um exemplo prático, mostrando sua aplicação no desenvolvimento de software.

## Padrões Implementados

- **Flyweight**: O padrão Flyweight é útil quando há um grande número de objetos similares que
compartilham dados comuns. Ele otimiza o uso de memória ao reutilizar instâncias de
objetos que têm estados idênticos. No exemplo, círculos de cores iguais são reutilizados em
vez de serem criados novamente, economizando memória. A classe CircleFactory
gerencia essa reutilização através de um dicionário que armazena círculos já criados. O
cliente solicita um círculo de uma cor específica; se já houver um círculo dessa cor, ele é
reutilizado, melhorando a eficiência.

  
- **Composite**: O padrão Composite permite a composição de objetos em uma estrutura de árvore para
representar hierarquias “parte-todo”. Ele facilita o tratamento uniforme de objetos
individuais e composições. No exemplo, um sistema de arquivos é criado onde arquivos e
pastas são tratados da mesma forma. A classe Directory pode conter tanto arquivos
quanto outras pastas, formando uma hierarquia. O método Display exibe a estrutura de
forma hierárquica, demonstrando como o padrão Composite permite manipular objetos
compostos de maneira uniforme, sem diferenciar entre arquivos e pastas
  
- **Bridge**:O padrão Bridge desacopla uma abstração de sua implementação, permitindo que ambos
evoluam independentemente. No exemplo, a interface IPlatform define métodos para exibir
janelas em diferentes plataformas (Windows, Linux, Mac). As classes de plataforma
implementam esses métodos com comportamentos específicos para cada sistema
operacional. A classe abstrata Window representa uma janela genérica, mantendo uma
referência à plataforma. As classes concretas de janela (DialogWindow, WarningWindow,
ErrorWindow) implementam o método Show, que chama o método da plataforma
correspondente. O cliente cria janelas para várias plataformas, demonstrando como o
padrão Bridge facilita a separação entre a lógica de exibição e a plataforma.

- **Proxy**: O padrão Proxy fornece um intermediário que controla o acesso a um objeto real,
permitindo a adição de funcionalidades extras como controle de acesso ou otimização. No
exemplo, a classe UserServiceProxy verifica se o usuário tem permissão para acessar o
serviço antes de encaminhar a solicitação ao RealUserService, que implementa a lógica
real. Se o usuário não for "Admin", o proxy bloqueia o acesso e exibe uma mensagem de
erro. O cliente utiliza o proxy para gerenciar permissões de diferentes usuários,
demonstrando como o padrão Proxy pode ser aplicado para segurança e controle de
acesso.

- **Decorator** :O padrão Decorator é um padrão estrutural que permite adicionar funcionalidades a objetos
de forma dinâmica, sem alterar sua estrutura original. No C#, ele é utilizado para estender
comportamentos de maneira flexível, como em sistemas de interface gráfica e manipulação
de dados.
No exemplo, temos a interface IMessage, implementada pela classe SimpleMessage para
exibir uma mensagem. Decoradores como EmailMessageDecorator e
WarningMessageDecorator estendem o comportamento dessa mensagem, sem modificar o
objeto original. A classe base MessageDecorator recebe um objeto IMessage e adiciona
novas funcionalidades, como exibir a mensagem com aviso ou em formato de email.
Os decoradores podem ser combinados, permitindo criar mensagens com múltiplas
características de forma dinâmica, seguindo o princípio de extensibilidade sem modificar o
código original. 

- **Adapter**: O padrão Adapter é um padrão estrutural que permite que duas interfaces incompatíveis
trabalhem juntas, agindo como uma ponte entre classes com diferentes interfaces. Ele é
comumente utilizado em C# para integrar componentes legados a sistemas novos sem
modificar o código existente.
No exemplo fornecido, temos duas interfaces: IEmailValidator, que o sistema espera, e
ILegacyValidator, usada por um validador legado. A classe EmailValidatorAdapter
implementa IEmailValidator e adapta a chamada do método IsValidEmail para o método
Validate da classe legada.
Assim, o Adapter possibilita que o sistema utilize o validador legado sem precisar alterar
sua implementação original, promovendo a integração de forma eficiente.

## Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/nome-do-repositorio.git


1. **Clone o repositório:**

   ```
   git clone https://github.com/seu-usuario/seu-repositorio.git
   cd seu-repositorio
Navegue até o diretório do projeto desejado:

Por exemplo, para o projeto Decorator:

    ```
    cd Decorator 
    
Compile o projeto:

    ```
      dotnet build

Execute o projeto:

```
dotnet run
