# OpenTK — Transformaciones 3D sobre un escenario

Proyecto en C# con OpenTK que dibuja un escenario con **dos letras "U" en 3D** y permite aplicar las tres transformaciones básicas — **rotación, traslación y escalado** — a todo el escenario, a cada objeto o a sus partes y caras, usando el teclado.

Los modelos se cargan desde un archivo JSON (`U.json`), de modo que la geometría no está escrita en el código.

> Proyecto académico — Programación Gráfica (ELC102), UAGRM (2025).

## Funcionalidades

- Jerarquía **Escenario → Objeto → Cara → Punto**.
- Carga y guardado de objetos en JSON (Newtonsoft.Json).
- Rotación respecto al centro de masa, al origen del objeto o al origen del escenario.
- Traslación y escalado en los tres ejes.
- Control por teclado (teclas `Q W E A S D F G H Z X C V B N`) para elegir la transformación y el eje.

## Tecnologías

- C# / .NET Framework 4.8
- OpenTK 3.1 (OpenGL)
- Newtonsoft.Json

## Estructura

```
Proyecto1_01.sln
Program.cs                 # Punto de entrada
src/clases/
├── Game.cs                # Ventana, escena y controles de teclado
├── Escenario.cs
├── Objeto.cs
├── Cara.cs
└── Extras/Punto.cs
bin/Debug/U.json           # Modelo de la letra U
```

## Requisitos

- Windows
- Visual Studio 2019 o 2022 con la carga de trabajo "Desarrollo de escritorio de .NET"
- .NET Framework 4.8

## Cómo ejecutar

1. Abrir `Proyecto1_01.sln` en Visual Studio.
2. Restaurar los paquetes NuGet (clic derecho en la solución → *Restaurar paquetes NuGet*). Las carpetas `packages/`, `bin/` y `obj/` no están en el repositorio: Visual Studio las genera al restaurar y compilar.
3. Ejecutar con **F5**. El archivo `U.json` debe estar junto al ejecutable (`bin/Debug`).
