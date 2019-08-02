# QuestionsApp
API Questions

Steps to run solution in Visual Studio 2013 or most recent version

STEP 1: Create Question table
- In a Sql Server 2012 or most recent version
- Select a database of your choice or create one  
- Run a sql script file 'SqlScripts/CreateTableQuestion.sql'

Next steps needs to be done in two locals
	- Project QuestionsWebApi: in Web.Config
	- Project QuestionsWebApi.Tests: in App.Config

STEP 2: Configure connection string
- Update de connection string to find question table create in STEP 1
- In 'configuration/connectionStrings' in item with name 'QuestionsConnectionString' modify de value of property 'connectionString'
	
STEP 3: Configure email settings (Optional)
- Current email settings will work for testing, the project is using a gmail account that was created just for that
- But if you want to change just modify de values in tag 'configuration/system.net/mailSettings/smtp' in the config files 

Future Improvements
- Leave only reference to entity framework in the QuestionsLibrary project
- Use a predicate to dynamic construct queries linq
