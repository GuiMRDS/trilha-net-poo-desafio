# 📱 Desafio POO - Sistema de Celulares

Este projeto foi desenvolvido como parte do módulo de **Programação Orientada a Objetos** da trilha **.NET** da [DIO - Digital Innovation One](https://www.dio.me). O objetivo é aplicar os conceitos fundamentais da orientação a objetos em um sistema de simulação de celulares.

## 🧠 Descrição do Desafio

Você é responsável por modelar um sistema que trabalha com celulares. Para isso, foi solicitado que você crie uma **abstração da classe `Smartphone`** e permita que diferentes marcas e modelos (como **Nokia** e **iPhone**) tenham seus próprios comportamentos, promovendo reutilização de código e aplicando os pilares da POO.

Este projeto representa um exercício prático da aplicação de herança, abstração e polimorfismo em C#.

## 🎯 Objetivos

- Criar uma classe abstrata `Smartphone` que não pode ser instanciada.
- Implementar as classes `Nokia` e `Iphone` como filhas de `Smartphone`.
- Sobrescrever o método `InstalarAplicativo` em cada classe filha, simulando comportamentos diferentes entre as marcas.
- Utilizar os princípios da Programação Orientada a Objetos: **abstração, encapsulamento, herança e polimorfismo**.

## 📐 Estrutura de Classes

### Classe abstrata: `Smartphone`

Contém as propriedades comuns de qualquer celular, como:
- Número
- Modelo
- IMEI
- Memória

E métodos como:
- `Ligar()`
- `ReceberLigacao()`
- `InstalarAplicativo()` (abstrato)

### Classes derivadas: `Nokia` e `Iphone`

Essas classes herdam de `Smartphone` e implementam o método `InstalarAplicativo()` de forma distinta, representando como cada sistema operacional instala aplicativos.

## 📌 Regras e Validações

- A classe `Smartphone` **deve ser abstrata** e **não pode ser instanciada diretamente**.
- As classes `Nokia` e `Iphone` devem obrigatoriamente **herdar de `Smartphone`**.
- O método `InstalarAplicativo` deve ser **obrigatoriamente sobrescrito** nas classes filhas, respeitando o comportamento específico de cada tipo de aparelho.

## 🎓 Conhecimentos Aplicados

- Lógica de Programação
- Programação Orientada a Objetos (POO)
- Classes e Herança
- Métodos Abstratos e Sobrescrita
- Estruturação de Projeto em C#

## 📚 Fonte

Projeto proposto pela **DIO - Digital Innovation One**, no curso **Trilha .NET - Programação Orientada a Objetos**.

---

### 👨‍💻 Feito por

**Guilherme Marinho**  
📘 [github.com/GuilhermeMarinho](https://github.com/GuiMRDS)
🚀 Desenvolvedor em formação na área de Análise e Desenvolvimento de Sistemas – UNIP  
🎯 Focado em C#, .NET, Web Design e Inteligência Artificial

---
