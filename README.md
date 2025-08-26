# Veterinaria - Proyecto con Ramas (ASP.NET Core MVC)

Este repo contiene 3 funcionalidades básicas para una veterinaria y un flujo de ramas Git:

- **Rama principal (`main`)**: solo el proyecto inicial.
- **Rama `feature/formulario-mascota`**: formulario de registro de mascotas (**más de un commit**).
- **Rama `feature/productos`**: CRUD básico de productos (**más de un commit**).

> Todas las ramas se fusionan sobre `main`. No quedan ramas huérfanas después de los merges.

## Requisitos
- .NET 8 SDK
- Git

## Ejecutar el proyecto
```bash
cd src/Veterinaria
dotnet run
# Navega a https://localhost:5001 o http://localhost:5000
```

## Crear ramas, commits y merges automáticamente
Hay dos scripts que generan el historial de Git con varias ramas y commits y luego fusionan todo en `main`:

### Windows (PowerShell)
```powershell
.\scripts\setup_git.ps1
```

### Linux/Mac (bash)
```bash
bash scripts/setup_git.sh
```

Al finalizar:
- `main` tendrá merges de ambas ramas.
- Las ramas `feature/formulario-mascota` y `feature/productos` estarán **eliminadas** (no huérfanas).
- Puedes consultar el log:
```bash
git log --graph --oneline --decorate --all
```

## Estructura
- `src/Veterinaria`: Código de la app (MVC minimal, almacenamiento en memoria).
- `scripts`: Scripts para crear el flujo de ramas y merges.

¡Éxitos con el examen!
