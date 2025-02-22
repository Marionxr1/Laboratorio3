1 Análisis del programa
Tareas Repetitivas o que pueden encapsularse en funciones
Considero que es repetitiva la función AgregarEstudiante, ya que se valida repetidamente el nombre del estudiante. Podría ser encapsulado en una función para reutilizarse en otros lugares donde se necesite validar nombres.
También la función ListaEstudiantes recorre las listas de estudiantes y calificaciones para mostrarlas. Se puede encapsular este comportamiento en una función separada que reciba las listas y las imprima para poder usarlas en otra parte del programa.
Variables Locales vs Variables Globales
¿Qué datos deben ser accesibles en todo el programa?
El listado de estudiantes, que debe ser accesible desde cualquier parte del programa, ya que varias funciones necesitan interactuar con esta lista.
La lista de calificaciones correspondientes a cada estudiante. Al igual que la lista de estudiantes, es necesario acceder a ella desde varias funciones ya que debe estar disponible para calcular promedios, mostrar la calificación más alta, o mostrar la lista completa de estudiantes con sus calificaciones.
¿Qué datos solo son necesarios dentro de una función específica?
string nombre en AgregarEstudiante:
Este es un dato local, que solo se necesita dentro de la función AgregarEstudiante. Se utiliza para capturar el nombre del estudiante y realizar las validaciones.
double calificacion en AgregarEstudiante:
La calificación solo se necesita dentro de la función AgregarEstudiante para realizar la validación y luego agregarla a la lista calificaciones. Esta variable solo es relevante en el contexto de agregar un nuevo estudiante, por lo que no debe estar disponible fuera de esta función.
double suma y double promedio en PromCal:
Estas variables solo se usan dentro de la función PromCal. La variable suma acumula las calificaciones, y promedio calcula el promedio. Estas variables son de uso temporal dentro del cálculo del promedio, por lo que no deben ser accesibles fuera de la función.


2 Modularizacion
Definir Variables Locales y Globales
¿Qué datos necesitan ser compartidos entre múltiples funciones?
Los datos que deben ser compartidos entre múltiples funciones son aquellos que deben ser accesibles desde diferentes partes del programa: List<string> estudiantes, List<double> calificaciones, int opcion.
¿Qué datos solo son relevantes dentro de una función específica?
Los datos que solo son relevantes dentro de una función específica son aquellos que no necesitan ser accesibles ni compartidos entre las distintas funciones del programa. Estos datos tienen un alcance limitado a la función en la que se utilizan, y una vez que esa función termina su ejecución, esos datos dejan de ser necesarios: string nombre en AgregarEstudiante, double calificación en AgregarEstudiante, double suma en PromCal.
3 Preguntas Guía
¿Qué ventajas tiene dividir el código en funciones?
Tiene varias ventajas importantes como tener mas claridad, al dividir el código en funciones, cada función tiene una responsabilidad clara. Esto hace que el código sea más fácil de leer y entender, también en la parte de la modularidad: Cada función se encarga de una tarea específica, lo que permite trabajar en pequeñas partes del código sin perder el enfoque. Facilita la depuración y mantenimiento, porque si hay un error en el programa, al tener las funciones separadas, podemos aislar fácilmente el problema en una función específica. Esto simplifica la depuración porque solo se necesita revisar la función que tiene el problema, en lugar de revisar todo el código.
¿Por qué es importante limitar el uso de variables globales?
Reduce la complejidad y aumenta la legibilidad del código, las variables globales están accesibles desde cualquier parte del programa, lo que puede hacer que el flujo de datos sea difícil de seguir. Si muchas funciones modifican la misma variable global, el código se vuelve menos predecible y más difícil de leer; el uso de variables globales puede causar efectos secundarios no deseados, ya que cualquier función o parte del código puede modificar la variable. Si no se gestionan adecuadamente, esto puede llevar a modificaciones imprevistas de valores que pueden afectar otras partes del programa.


¿Cómo se puede mejorar la legibilidad del código?
Usar nombres significativos para variables, funciones y clases, Los nombres deben ser claros y describir exactamente el propósito de la variable, función o clase. Esto ayuda a entender rápidamente qué hace cada parte del código sin necesidad de profundizar demasiado en la lógica. En las variables el nombre debe reflejar el tipo de dato que almacena y su propósito, en las funciones el nombre debe indicar que es lo que hace, especialmente con verbos. Los comentarios son útiles para explicar partes del código que podrían ser confusas o complejas. Pero tampoco se debe abusar de ellos. Pueden comentar lo que hace el código explicando el porque de ciertas decisiones.
