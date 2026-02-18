# Developer Daily Hub

Developer Daily Hub is an API-first productivity hub for developers to track:
- Tasks
- Learning logs
- Job / internship applications
- Current repo/build checklist

This project intentionally starts **without a front-end UI**. Swagger is the temporary “UI” so the app is usable immediately while the backend is built.

## Tech Stack
- ASP.NET Core Web API (.NET)
- Swagger / OpenAPI
- NUnit (automated tests) *(next)*
- EF Core + SQLite *(soon)*
- JWT Authentication *(soon)*

## Run Locally
1. Open the solution in Visual Studio
2. Press **F5**
3. Open Swagger:
   - `https://localhost:<port>/swagger`
   - The port number will appear in the Visual Studio output window when running the app. 

## Project Goals
- Resume-worthy backend architecture
- Automated API test suite (QA automation fallback)
- Clean Git workflow (feature branches + PRs)
- Daily practice in a dedicated `lab` branch

## Roadmap (near-term)
- [ ] Add NUnit test project
- [ ] Add `/api/status` endpoint
- [ ] Add JWT auth (register/login)
- [ ] Add Tasks module (CRUD)
- [ ] Add EF Core persistence + migrations