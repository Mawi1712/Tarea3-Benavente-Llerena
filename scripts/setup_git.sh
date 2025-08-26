#!/usr/bin/env bash
set -euo pipefail

# Ubicarse en la raíz del proyecto (scripts/ -> .)
cd "$(dirname "$0")"
cd ..

# Init repo
git init
git config user.name "Alumno"
git config user.email "alumno@example.com"

# Main con solo proyecto inicial
git checkout -b main
git add .
git commit -m "chore: proyecto inicial Veterinaria (MVC, modelos y vistas básicas)"

# Rama 1: Formulario de Registro de Mascota (más de un commit)
git checkout -b feature/formulario-mascota

# Commit 1
printf "\n<!-- mejora: placeholders y ayuda -->\n" >> src/Veterinaria/Views/Pets/Registrar.cshtml
git add src/Veterinaria/Views/Pets/Registrar.cshtml
git commit -m "feat(pets): mejorar formulario de registro con placeholders y ayuda"

# Commit 2
printf "\n<!-- mejora: mensaje de éxito -->\n" >> src/Veterinaria/Views/Pets/Lista.cshtml
git add src/Veterinaria/Views/Pets/Lista.cshtml
git commit -m "feat(pets): agregar mensaje de éxito en listado"

# Merge a main
git checkout main
git merge --no-ff feature/formulario-mascota -m "merge: integrar feature formulario de mascota a main"
git branch -d feature/formulario-mascota

# Rama 2: Productos (más de un commit)
git checkout -b feature/productos

# Commit 1
printf "\n<!-- nota: categorías sugeridas -->\n" >> src/Veterinaria/Views/Products/Crear.cshtml
git add src/Veterinaria/Views/Products/Crear.cshtml
git commit -m "feat(productos): nota de categorías sugeridas en formulario crear"

# Commit 2
printf "\n<!-- mejora: filtros de categoría visibles -->\n" >> src/Veterinaria/Views/Products/Index.cshtml
git add src/Veterinaria/Views/Products/Index.cshtml
git commit -m "feat(productos): mejorar filtros por categoría en listado"

# Merge a main
git checkout main
git merge --no-ff feature/productos -m "merge: integrar feature productos a main"
git branch -d feature/productos

echo "Listo. Revisa el historial con: git log --graph --oneline --decorate --all"
