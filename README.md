## Passos para o Parser

1. **Abrir o Arquivo CSV**
   - Abra o arquivo CSV para leitura.

2. **Ler o Arquivo Linha por Linha**
   - Use um loop para ler o arquivo linha por linha.

3. **Separar Campos**
   - Para cada linha, divida a linha em campos usando o delimitador CSV.

4. **Gerenciar Aspas e Caracteres Especiais**
   - Se um campo estiver entre aspas, trate-o como uma unica unidade, mesmo que contenha virgulas ou quebras de linha.
   - Remova aspas extras e escape de caracteres especiais conforme necessario.

5. **Armazenar Dados**
   - Armazene os dados separados em uma estrutura apropriada, como uma lista de listas ou uma lista de objetos.

6. **Fechar o Arquivo**
   - Feche o arquivo apos a leitura completa.