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

## 🧱 Diagrama de Classes (UML simplificado)
