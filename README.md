"# Calculator" 
### comandos usados para criar o projeto

* Use sempre pastas com o caminho mais curto 
* recomendo criar uma pasta no diretorio raiz C:/dev coloquei o nome deve somente como exemplo mais pode ser temp ou qualquer outro.
* dentro dessa pasta você pode organizar como quiser eu gosto de criar um diretorio com o nome projetos e organiza-los dentro da mesma.

* obs: precisar ter instalado o dotnet 5 instalado e sdks 3.1.
COMANDO:
Verificar quais sdks você tem instalados:
dotnet --list-sdks
Caso tenha o 3.1 é só prosseguir com o comando abaixo.
dotnet new console -n Calculator -o Calculator -f netcoreapp3.1


Caso Precise instalar a versão 3.1 comando abaixo:
Comando:
dotnet tool install --global dotnet-ef --version 3.1.5

verificar se foi instala-do
Comando:
dotnet ef
