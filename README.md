## Backend Project

## Description of future features
- Try/Catch + Error Handling
- Sql Server backend database and removal of table data from appsettings
  -- Tables needed: StateFactorDetail, BusinessFactorDetail, CalculationsTable (Holds type of calculation (BasePremium, HazardFactor, etc.) and formula - Still pondering this)
- Complete documentation of request and response objects using Swagger
- Additional testing in Postman for other state and business premium calculations
- Extended endpoints to support API
  -- Broker/Dealers and Agents
  -- Policy Endpoints
  -- Commission Endpoints
- Security for system/PII/etc. 

## Instructions for running and testing API
- Clone project from GitHub: https://github.com/RaeBroome/Coterie.git
- Open Visual Studio
- Select Clone or check out code
- Paste https://github.com/RaeBroome/Coterie.git in Repository location textbox
- Enter the directory path for the project in the Local path textbox
- Click on the Clone Button
- In Solution Explorer, open the CoterieQuoteAPI
- DoubleClick on CoterieAPI.sln
- Run the application in IIS Express
- Open Postman
- Select File/Import. The Import window will appear. 
- Select Upload Files. Navigate to the directory you created for the project. Open the Postman directory. Select Coterie.postman_collection.json file.
- The Import window will display. Click the Import button. 
- Open the GetBusinessPremiumQuote POST request.
- Go to the Swagger window of the API running. Copy the port number from swagger. An example is 44328. However your local copy may have a different port number. 
- Paste the port number after the endpoint address. An example is: https://localhost:44316/api/Rating/GetBusinessPremiumQuote
- Click the Send button in Postman. The calculated response is diplayed. 

## Deliverables Checklist
- [X] API written in .NET Core
- [X] API accepts `POST` and returns data per above requirements
- [X] Repo README has instructions for running and testing the API
- [X] Repo README has information about what you'd do next, per above requirements
