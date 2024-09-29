# Projetos de Padrões de Design em C#

Este repositório contém exemplos de implementação de padrões de design estruturais em C#.

## Requisitos

- [.NET SDK](https://dotnet.microsoft.com/download) (versão 6.0 ou superior)

# Padrões de Design em C#

Este repositório contém exemplos de padrões de design estruturais implementados em C#. Cada padrão é demonstrado através de um exemplo prático, mostrando sua aplicação no desenvolvimento de software.

## Padrões Implementados

- **Flyweight**: Otimiza o uso de memória ao reutilizar objetos com estados semelhantes. Um exemplo é a reutilização de círculos com cores iguais.
  
- **Composite**: Permite a criação de estruturas em árvore para representar hierarquias parte-todo. Exemplo: sistema de arquivos onde pastas e arquivos são tratados de maneira uniforme.
  
- **Bridge**: Desacopla abstrações de suas implementações, permitindo que ambos evoluam separadamente. Exemplo: janelas exibidas em diferentes plataformas.

- **Proxy**: Controla o acesso a um objeto, adicionando funcionalidades extras como controle de acesso. Exemplo: verificação de permissões antes de acessar um serviço.

- **Decorator**: Adiciona funcionalidades a objetos de forma dinâmica, sem modificar sua estrutura original. Exemplo: mensagens decoradas com novos comportamentos.

- **Adapter**: Permite que interfaces incompatíveis trabalhem juntas. Exemplo: adaptação de um validador legado para uma interface moderna.

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
