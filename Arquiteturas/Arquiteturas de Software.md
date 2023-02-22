
## Sistemas com arquitetura de n-camadas

- Pode-se pensar em uma aplicação web dinâmica, que tem uma interface, lógica de negócios, serviços e um banco de dados.

Geralmente os sistemas são projetados em três camadas ou mais:
 - **Camada de Armazenamento (DS - Data Store)**: Camada onde os dados são armazenados
 
 - **Camada de Acesso aos Dados (DAL - Data Acess Layer)**: Camada que trata de obter e retornar os dados salvos na camada de armazenamento
 
 - **Camadade de Lógica de Negócios (BLL - Business Logica Layer)**: Camada que obtém os dados pela DAL e repassa ao cliente de forma mais intuitiva.

 - **Camada de Apresentação (UI - User Interface)** : Camda que define o que será apresentado.