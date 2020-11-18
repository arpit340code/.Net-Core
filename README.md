# Git Cmnds
VCS (Version Control system) - GIT 
SCM (Source control management) - Github - Distributed SCM system

Create New Repositoty

Public and private repositories

Download git for windows/ mac(if available)

Right click in directory and then git bash here
git clone https://github.com/arpit340/Links.git   
Used for the first time

git pull
For getting the latest

git status
For checking the git status

git add filename
Add file to staged changes

git add -a 
Add all the files to staged changes 

git commit -m "Commit message"
Commit the changes on local workspace

git push origin master
Pushed the changes to the remote server (github)

git remote -v
Tells the repositoty in case of multiple repo

Initialising the New Repository from your computer

git init
Intialise the repo

echo "test text" >> README.md
Creates the readme file

git status
Check the status

git add.
Adds only the new ones and modified from current directory 

git add abc.txt pqr.txt
Add only these two files

git add -all
Adds all the files

git commit -m "new repository initialise"
commits on local m/c

git remote add origin https://github.com/arpit340/.Net-Core.git
Add/maps to the remote URL 

Check the Mapping or repository linked 
git remote -v

git push origin master
Pushes the files to the remote

First get the code from repo or clone on local sysytem, then commit and push the code
git init
git status
git add -a     							
//. for all the files
git commit -a -m"new repository"
git remote add origin https://github.com/arpit340/.Net-Core.git
git pull origin master
git push origin master

>git push origin master	        
//master is my branch name
git config --global http.proxy http://arpit.jain:omomom%40123@192.168.55.118:8080
git push -u origin –all					
Asked for Username and Password

Branch - 
List all the git branches
git branch

add Branch
git branch branchname

Checkout on particular branch or work on the particular branch
git checkout branchname

Push changes to branch
git push origin banchname

To create branch except master then checkout that branch then check with
git branch command for the checkout branch & then use the 

Create new branch and checkout to that branch
git checkout -b branchname

Rename Branch
git branch -m oldbranchname newbranchname

Merge Branch from Master to Development or other branch etc
Use the pull request from the github then merge the branch by specicifying the branch from where to merge and to which branch to merge
or

git merge branchname(from where the changes are to be merged or taken)
E.g git merge master





# .Net-Core
.Net Core Learning


# Links
https://docs.microsoft.com/en-us/dotnet/architecture/modern-web-apps-azure/common-web-application-architectures


