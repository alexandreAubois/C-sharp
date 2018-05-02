# Cours de C#

## Création de la structure 

### Création des projets indépendants

Création de la solution :  
`mkdir Isen.Cs && cd Isen.Cs`  
`dotnet new sln`  
Création du projet de type console :  
`mkdir Isen.Cs.ConsoleApp && cd Isen.Cs.Console`  
`dotnet new console`  
Création du projet de type librairie (depuis la racine) :   
`mkdir Isen.Cs.Library && cd Isen.Cs.Library`  
`dotnet new classlib`  
Création du projet de type tests unitaires (depuis la racine) :  
`mkdir Isen.Cs.Tests && Isen.Cs.Tests`  
`dotnet new xunit`  

### Référencement des projets   

Ajouter au projet console une référence vers le projet Library.  
Depuis le dossier du projet console :  
`dotnet add reference ..\Isen.Cs.Library\Isen.Cs.Library.csproj`  
Depuis le dossier du projet tests :  
`dotnet add reference ..\Isen.Cs.Library\Isen.Cs.Library.csproj`  

### Indiquer au sln la présence des 3 projets 

Depuis la racine de la solution :
`dotnet sln add Isen.Cs.Library\Isen.Cs.Library.csproj`
`dotnet sln add Isen.Cs.Tests\Isen.Cs.Tests.csproj`
`dotnet sln add Isen.Cs.ConsoleApp\Isen.Cs.ConsoleApp.csproj`

### Ménage 
Effacer les fichier .cs générés automatiquement, à l'exception de celui du projet Console.  

### Build pour vérifier  
Il y a 3 étapes, qui s'appellent entre elles, lors d'un build :  
* `dotnet restore` : restaurer les packages "NuGet" distants (mécanise équivalent à `npm`).  
* `dotnet build` : compiler les projets 
* `dotnet run` : exécuter dans la console, s'il est exécutable  
    * Exécuter dans la console, pour un projet Console 
    * Lancer un serveur web, pour un projet web

### Initial commit 
Créer un projet sur Github ou Gitlab.  
`git init`  
Trouver un .gitignore pour un projet .net Core
`git add .`
`git commit -m "initial commit, project structure"`
`git remote add origin https://github.com/alexandreAubois/C-sharp`
