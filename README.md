
# 🎓 Plateforme E-Learning – Projet Universitaire (Blazor Server)

Ce projet est une **plateforme de formation en ligne** inspirée de Coursera/Udemy, développée avec **Blazor Server (.NET 8)** et **SQL Server**, dans le cadre d’un projet académique. Il permet à des étudiants de suivre des cours en ligne, visionner des vidéos, répondre à des quiz, et suivre leur progression. Les enseignants peuvent créer et gérer leurs cours. Le projet intègre aussi des aspects DevOps modernes avec **Docker**, **Git** et **Kubernetes**.

---

## 🧩 Fonctionnalités Principales

- ✅ Authentification sécurisée (étudiants, enseignants, administrateurs)
- 🎥 Lecture de vidéos de formation
- 📝 Création de cours et modules par les enseignants
- ❓ Quiz interactifs et suivi des résultats
- 📊 Suivi de progression de l’étudiant
- 📥 Tableau de bord personnalisé
- 🔔 Notifications en temps réel via SignalR
- ⚙️ Interface d’administration

---

## 🛠️ Stack Technique

| Couche                   | Technologie            |
|--------------------------|------------------------|
| Frontend & Backend       | Blazor Server (.NET 8) |
| Base de données          | SQL Server             |
| ORM                      | Entity Framework Core  |
| Authentification         | ASP.NET Identity       |
| UI                       | Bootstrap 5            |
| Communication temps réel| SignalR                |
| Versioning               | Git, GitHub            |
| Conteneurisation         | Docker                 |
| Orchestration            | Kubernetes             |

---

## 🚀 Lancement du Projet

### ✅ Prérequis

- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/fr-fr/sql-server/sql-server-downloads)
- [Docker](https://www.docker.com/)
- [Kubernetes](https://kubernetes.io/) 
- Git

---

### 🔧 Étapes d’installation manuelle

1. **Cloner le projet**

   ```bash
   git clone https://github.com/votre-utilisateur/elearning-platform.git
   cd elearning-platform

### 🔧 Étapes d'installation manuelle (suite)

-   **Configurer la base de données**
    -   Créer une base nommée `ElearningDb`
    -   Modifier `appsettings.json` :


```json
"ConnectionStrings": { "DefaultConnection": "Server=VOTRE_SERVEUR;Database=ElearningDb;Trusted_Connection=True;MultipleActiveResultSets=true" }
```

-   **Appliquer les migrations**


```bash
dotnet tool install --global dotnet-ef
dotnet ef database update
```

-   **Lancer l'application**

bash

```bash
dotnet run
```

Accès via : 🔗 `http://localhost:5000`
