# Sistema basico de atendimento

## 📌 Descrição do Projeto
Este projeto consiste em um sistema simples de gerenciamento de chamados de suporte técnico.
O sistema permite o cadastro de clientes e técnicos, abertura de chamados, atribuição de técnicos,
classificação por categorias, atualização de status e registro de histórico de atendimentos.

O foco do projeto é a aplicação correta dos conceitos de Orientação a Objetos e dos princípios SOLID.

---

## 📐 Diagrama de Classes UML

![image alt](https://github.com/pedrin08-rgb/sistema-basico-de-atendimento/blob/f9409cb1ccb3846ba243cf33cb3e690ce63721b1/Screenshot_20260206_211823_Canva.jpg)

## 🧠 Conceitos de Orientação a Objetos Utilizados

- Classe e Objeto
- Encapsulamento
- Herança
- Polimorfismo
- Abstração
- Interfaces
- Classes abstratas
- Construtores
- Métodos sobrescritos (override)

---

## 🧩 Aplicação dos Princípios SOLID

### S – Single Responsibility Principle
- A classe `Chamado` é responsável apenas por armazenar os dados do chamado.
- A classe `ChamadoService` é responsável pelas regras de negócio.

### O – Open/Closed Principle
- O sistema permite adicionar novos tipos de usuários ou categorias sem alterar o código existente.

### L – Liskov Substitution Principle
- As classes `Cliente` e `Tecnico` podem substituir a classe `Usuario` sem causar falhas no sistema.

### I – Interface Segregation Principle
- Foram utilizadas interfaces pequenas e específicas:
  - `IAtribuivel`
  - `IEncerravel`

### D – Dependency Inversion Principle
- As regras de negócio dependem de interfaces e não de implementações concretas.

---

## 🛠 Tecnologias Utilizadas
- C#
-.NET
-Programação Orientada a Objetos
-UML

---

## 👨‍🎓 Aluno
- Reginaldo Pedro




