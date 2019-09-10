# TesteDotNet

Software desenvolvido com base no teste abaixo, foram realizadas algumas modificações para facilitar a utilização do mesmo pelo usuário.

## Projeto Teste C#
### O questionário é sequencial, porém não é obrigatório responder todas as questões. Responda o máximo de questões que puder e tente utilizar boas práticas de desenvolvimento.
- 1 – Criar uma aplicação console em .NET Core mais recente com nome de TesteDotNet;
- 2 – Ao executar a aplicação exiba uma mensagem de boas vindas (Seja bem vindo!!!);
- 3 – A aplicação é uma calculadora. Crie métodos para as 4 operações básicas (Soma, Subtração, Multiplicação e
Divisão), que receba 2 números como argumentos e cada método deve retornar um resultado;
- 4 – Crie um tratamento de exceção em todas as operações, em caso de erro informe na tela uma mensagem de erro
compreensível com (nome da operação, os valores repassados para a operação), e se puder crie tipos diferentes de
exceções (Exiba a mensagem na tela em cor vermelha);
- 5 – Exiba para o usuário quais tipos de operação ele pode executar;
- 6 – De alguma forma deixe o usuário escolher qual operação será executada, receba o parâmetro em uma única linha
separado por ; (ponto e virgula);
- 7 – Valide se o parâmetro informado é válido. Se não for informe uma mensagem de argumento inválido;
- 8 – Retorne um valor da operação executada para o usuário em caso de operação válida;
- 9 – Após exibir o resultado, exiba a mensagem “Pressione qualquer tecla para continuar ou ESC para sair”. Caso o
usuário aperte qualquer tecla exceto ESC, exiba novamente o que fez na questão 5, e caso o usuário apertar ESC, exiba
uma mensagem de despedida “Obrigado por utilizar nossa calculadora” e após 2 segundos encerre a aplicação;
- 10 – Crie uma sobrecarga do método de soma que receba uma quantidade ilimitada de números e que retorne a soma
de todos esses números;
- 11 – Crie um novo método que calcule a média de uma quantidade ilimitada de números e exiba na tela;
- 12 – Faça um método igual ao da questão 10 mas utilize para a operação somente os números pares, ignorando os
ímpares;
- 13 – Crie um arquivo de texto com as seguintes informações:
```
José;Soma;10;2
Adailtom;Divisao;10;2
Raimundo;Multiplicacao;10;2
Antonio;Subtracao;10;2
Joaquim;Subtracao;10;2
Paula;Divisao;10;2
“deixe essa linha em branco”
SEUNOME(informe seu nome completo);Soma;10;20;2;5;12
```
- 14 – Leia o arquivo que criou e execute as operações repassadas e armazene em um dicionário onde a chave é o nome
da pessoa e o valor é o resultado da operação, e imprima na tela.
