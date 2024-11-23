# Proyecto de gestión de productos y usuarios en C# y MySql.

Este proyecto es un trabajo final de programación 1 de la carrera de Desarrollo de Software, implementa un sistema de login básico utilizando C# y MySql para gestionar la autenticación de usuarios. Además, registra el historial de accesos de los usuarios y valida los datos en el proceso de login y registro. 

## Características

- **Autenticación de usuarios**: Los usuarios pueden ingresar con su nombre de usuario y contraseña.
- **Contraseñas seguras**: Las contraseñas se almacenan de forma segura utilizando hashing con SHA256.
- **Registro de accesos**: Cada vez que un usuario inicia sesión, se registra su acceso en una base de datos.
- **Validación de contraseña**: La contraseña debe cumplir con ciertos requisitos (mínimo 8 caracteres, al menos una mayúscula, un carácter especial).
- **Interfaz de usuario**: Interfaz gráfica para ingresar datos de login y mostrar el estado del login.

## Tecnologías Utilizadas

- **C#**: Lenguaje de programación utilizado para el backend.
- **MySql**: Base de datos para almacenar los usuarios y sus datos de acceso.
- **SHA256**: Algoritmo de hashing utilizado para almacenar las contraseñas de forma segura.
- **WinForms**: Herramienta de C# para la interfaz.

## Requisitos

1. **Microsoft Visual Studio** (o cualquier IDE compatible con C#).
2. **SQL Server** o **MySql WorkBench**.
3. **.NET Framework** o **.NET Core** (según el tipo de proyecto).

## Credenciales de administrador (los datos ya estan cargados en la base de datos):
Se encuentran el archivo settings.json.

## Instalación
1. Abrir el archivo inventario.sql con un gestor de bases de datos (MySql WorkBench por ejemplo).
2. Crear una base de datos llamada inventario.
3. Copiar el contenido de el archivo inventario.sql a la base de datos previamente creada en el paso 2.
4. Configurar la base de datos desde el archivo model.cs.
5. Ejecutar aplicación.
