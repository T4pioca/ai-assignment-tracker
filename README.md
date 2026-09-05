# AI Assignment Tracker

A web app that helps track assignments and deadlines, built as a hands-on learning project for modern full-stack development — with an AI layer that can pull assignment details straight out of typed text or a photo of a handout.

## Why this project exists

This is a first full-stack project, built specifically to get real, hands-on experience with the pieces of a modern web app: a REST API, a real database, a separate frontend talking to it over HTTP, and (eventually) an AI integration on top. Every tool was chosen with one constraint in mind: **zero cost**, since this is a student project.

## Tech stack

**Backend**
- ASP.NET Core Web API (.NET 10) — C#
- Entity Framework Core — object-relational mapping, migrations
- SQL Server LocalDB — free, local database, no server setup required

**Frontend**
- React + Vite — JavaScript
- Axios — API calls

**AI**
- Google Gemini API (free tier) — reads typed text *or* a photo directly and extracts structured assignment details (title, course, due date, priority) in one step, no separate OCR needed

**Tooling**
- Visual Studio Community
- Git + GitHub

## Project structure
ai-assignment-tracker/
├── AssignmentTracker.Server/ # ASP.NET Core Web API backend
│ ├── Controllers/ # API endpoints (AssignmentsController)
│ ├── Models/ # Data models (Assignment)
│ ├── Data/ # AppDbContext (EF Core)
│ └── Migrations/ # EF Core migration history
└── client/ # React frontend (Vite)
└── src/
├── api/ # API call wrappers
└── App.jsx # Main UI

## Features

**Working now:**
- [x] Full CRUD API for assignments (create, read, update, delete)
- [x] SQL Server database via EF Core migrations
- [x] React UI: view assignment list, add new assignments, delete assignments

**Planned:**
- [ ] Mark assignments complete
- [ ] User authentication (ASP.NET Core Identity)
- [ ] AI extraction: paste text or upload a photo, auto-fill assignment details via Gemini
- [ ] Automatic priority scoring based on due date and course weight
- [ ] Dashboard polish (sorting, filtering, urgency indicators)

## Running it locally

**Backend**
1. Open `AssignmentTracker.Server` in Visual Studio
2. Press F5 (runs on `https://localhost:7206`)

**Frontend**
1. `cd client`
2. `npm install` (first time only)
3. `npm run dev` (runs on `http://localhost:5173`)

Both need to be running at the same time for the app to work end to end.
