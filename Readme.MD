# TESTES UNITÁRIOS

Existem vários tipos de testes de software:
 - Unitários;
 - Integração;
 - Regressivo;
 - Segurança, etc.

 O teste serve principalmente para validar se o que foi construído está
 atendendo ao que é esperado.

 E o teste unitário está ligado ao desenvolvedor que irá fazer um teste
 mais técnico do sistema.

 Bom, agora finalmente:

 # O que são Testes Unitários?

 São testes realizados diretamente no código fonte, buscando testar a menor
 unidade de código possível, através de casos que podem ocorrer no sistema.

 Ou seja, o dev vai criar um código para testar o código do projeto desenvolvido desenvolvido.

 ## Exemplo:

Um usuário do sistema só é cadastrado se possuir um CPF e um email VÁLIDO.
Caso contrário, retornará um erro indicando o que está errado.

Daqui podemos abastrair alguns possíveis casos de teste:

 - Usuário com todos os dados válidos;
 - Usuário com CPF inválido;
 - Usuário com email inválido.

 Os cenários negativos é para ver se realmente o erro está retonando alguma mensagem(aviso).

 ## Vantagens:

  - A principal vantagem é a qualidade do sistema;
  - Garante que a alteração não tenha impactos no sistema;
  - Menos bugs;
  - Maior confiança de que suas classes e métodos funcionam;
  - Prevenir problemas futuros.

  ## Frameworks de Teste

   - MSTest
   - NUnit
   - xUnit => O mais usado.