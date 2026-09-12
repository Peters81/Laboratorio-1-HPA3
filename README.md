# Laboratorio 1 - HPA3

---

## Universidad Tecnológica de Panamá

**Facultad de Ingeniería de Sistemas Computacionales**

**Ingeniería en Sistemas y Computación**

**Herramientas de la Programación Aplicada III (.NET)**

---

## Información del laboratorio

| Dato | Información |
|---|---|
| **Laboratorio** | Laboratorio #1 |
| **Estudiante** | Cristell Peters |
| **Grupo** | 1II133 |
| **Año** | 2026 |
| **Fecha de ejecución** | 15 de abril de 2026 |

---

## Objetivos

🟠 Comprender el uso de controles básicos en aplicaciones Windows Forms.

🟠 Aplicar conceptos básicos de programación utilizando C#.

🟠 Utilizar estructuras condicionales para resolver diferentes problemas.

🟠 Trabajar con diferentes controles y propiedades de Windows Forms.

---

## Introducción

En este laboratorio se desarrollaron tres prácticas utilizando el lenguaje C# y aplicaciones Windows Forms. Las actividades permitieron trabajar con diferentes controles de la interfaz, propiedades, eventos y estructuras de programación.

A través de las prácticas se aplicaron conceptos básicos de programación para crear aplicaciones capaces de recibir información del usuario, procesarla y mostrar los resultados correspondientes.

---

## Contenido del repositorio

El repositorio contiene las tres prácticas desarrolladas durante el Laboratorio #1:

🟠 **Pract1-Controles:** práctica enfocada en el uso de controles básicos de Windows Forms.

🟠 **Descuentos:** aplicación para calcular descuentos de acuerdo con el valor de una venta.

🟠 **Pract8-EstructuraIf:** aplicación que utiliza estructuras condicionales y diferentes opciones de operación.

---

## Tecnologías utilizadas

🟠 **Lenguaje:** C#

🟠 **Plataforma:** .NET Framework

🟠 **Tipo de aplicación:** Windows Forms

🟠 **IDE:** Visual Studio

🟠 **Control de versiones:** Git y GitHub

---

## Requisitos previos

Para ejecutar los proyectos se necesita contar con:

🟠 Sistema operativo Windows.

🟠 Visual Studio.

🟠 Herramientas para el desarrollo de aplicaciones Windows Forms.

🟠 .NET Framework correspondiente al proyecto.

---

# Prácticas desarrolladas

## 1. Pract1-Controles

En esta práctica se trabajó con diferentes controles básicos de Windows Forms, incluyendo `Label`, `TextBox` y `Button`.

Se desarrollaron acciones mediante botones para mostrar información ingresada por el usuario y presentar mensajes utilizando `MessageBox`.

También se trabajó con la propiedad `Text` y con los operadores `+` y `+=`.

### Evidencia

![Práctica 1 - Controles](./imagenes/pract1-controles.png)

---

## 2. Descuentos

En esta práctica se desarrolló una aplicación para calcular el descuento correspondiente según el valor de una venta.

| Valor de la venta | Descuento |
|---|---:|
| $500 o más | 30% |
| Más de $300 hasta $499 | 20% |
| Más de $100 hasta $299 | 10% |
| $100 o menos | 0% |

El programa permite obtener el porcentaje de descuento, el monto descontado y el valor final de la venta.

Para los controles se utilizó la nomenclatura indicada en la práctica, como `lbl` para Labels, `btn` para Buttons y `txt` para TextBoxes.

### Evidencia

![Práctica 2 - Descuentos](./imagenes/descuentos.png)

---

## 3. Pract8-EstructuraIf

En esta práctica se trabajó con la estructura condicional `If` y con controles como `GroupBox` y `RadioButton`.

El usuario puede ingresar los valores correspondientes y seleccionar la operación que desea realizar. Dependiendo de la opción seleccionada, el programa ejecuta la operación correspondiente.

Las operaciones utilizadas son:

🟠 Suma

🟠 Resta

🟠 Multiplicación

🟠 División

### Evidencia

![Práctica 3 - Estructura If](./imagenes/pract8-estructura-if.png)

---

# Estructura del repositorio

```text
Laboratorio-1-HPA3/
│
├── Descuentos/
│
├── Pract1-Controles/
│
├── Pract8-EstructuraIf/
│
├── imagenes/
│   ├── pract1-controles.png
│   ├── descuentos.png
│   └── pract8-estructura-if.png
│
├── .gitignore
└── README.md
