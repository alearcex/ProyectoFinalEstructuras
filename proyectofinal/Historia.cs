using System;
using System.Runtime.Intrinsics.X86;

namespace arbolbinario
{
    internal class Historia
    {
        public static void MostrarHistoriaCompleta()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t \t \t \t VAMOS A BUSCAR UN TESORO\n");
            Console.ResetColor();
            Console.WriteLine(
                "En algún lugar del mundo, en un sitio escondido y envuelto en misterio, se encuentra un peculiar Bosque llamado Frondoso. \n" +
                "Este bosque es famoso por sus historias mágicas y secretos ancestrales que han cautivado la imaginación de los aventureros durante siglos. \n" +
                "Las leyendas hablan de un tesoro escondido, un premio codiciado por muchos, pero ninguno ha logrado regresarlo al mundo conocido. \n" +
                "A lo largo de los años, las historias sobre el bosque han crecido, llenas de valentía y desgracia. Los que se atreven a adentrarse en él son \n" +
                "frecuentemente objeto de críticas y murmullos en el pueblo cercano. Se les considera avariciosos y temerarios por intentar desentrañar \n" +
                "un misterio que ha desafiado a tantas generaciones sin éxito. La gente del pueblo, con una mezcla de escepticismo y desdén, \n" +
                "se burla de aquellos que buscan el tesoro, llamándolos soñadores imprudentes que arriesgan sus vidas por un mito.\n" +
                "Desde pequeño, el aventurero había escuchado estas historias y comentarios negativos sobre el bosque. En lugar de desanimarlo, \n" +
                "estas historias alimentaron sus sueños y aspiraciones. Siempre soñó con ser él quien se adentrara en el bosque y regresara con el tesoro \n" +
                "que tantos habían buscado en vano. Su espíritu aventurero lo llevó a explorar todos los rincones cercanos al pueblo. \n" +
                "Con el tiempo, todas las aventuras locales se volvieron familiares y predecibles, dejando solo un gran desafío por enfrentar: \n" +
                "el enigmático Bosque Frondoso. Finalmente, decidió que era el momento de buscar su sueño y adentrarse en el bosque, dispuesto a enfrentar \n" +
                "los desafíos y descubrir si el tesoro era más que una simple leyenda.\n");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.WriteLine(
                "\nEl aventurero, con gran determinación, emprendió su camino hacia el bosque. A medida que avanzaba, la atmósfera se volvía cada vez más densa y misteriosa. \n" +
                "La niebla se arremolinaba a su alrededor, creando un velo que hacía que la visibilidad fuera casi nula. Los susurros del viento parecían hablar en un lenguaje incomprensible, \n" +
                "como si el bosque tuviera su propio idioma secreto. Cada crujido de las ramas y cada sombra que se movía entre los árboles aumentaba la sensación de inquietud.\n" +
                "A medida que el aventurero se adentraba más en el bosque, el suelo se volvía irregular y las raíces de los árboles se entrelazaban, formando obstáculos naturales en su camino. \n" +
                "Las hojas secas crujían bajo sus pies, y el aire estaba impregnado con el aroma de humedad y musgo. En algunos lugares, el sendero se estrechaba hasta casi desaparecer, \n" +
                "y en otros, se abrían claros que permitían ver los altos árboles que se alzaban como gigantes protectores.\n" +
                "Finalmente, llegó a un cruce de caminos donde debía tomar una decisión crucial. A la izquierda, un río caudaloso se extendía frente a él, \n" +
                "con una corriente fuerte y peligrosa que susurraba promesas de secretos ocultos más allá de sus aguas turbulentas. \n" +
                "A la derecha, se veía una casa antigua y aparentemente abandonada, con ventanas polvorientas y una puerta que parecía crujir al ser movida por el viento. \n" +
                "El aventurero debía elegir entre arriesgarse a cruzar el río o investigar la casa en busca de pistas y quizás algún otro secreto escondido. \n" +
                "Ambas opciones prometían desafíos y misterios, y debía decidir cuál camino tomar para seguir su búsqueda.\n");
        }
        public static void MostrarOpcionRío()
        {
            Console.WriteLine(
                "El aventurero decidió dirigirse al río. El río rugía con una corriente poderosa que desafiaba su determinación. \n" +
                "Las aguas eran turbias y tumultuosas, y el aventurero tuvo que enfrentarse a un sendero estrecho y resbaladizo para llegar a un punto donde pudiera intentar cruzar. \n" +
                "Mientras avanzaba, las piedras bajo el agua se movían y él tenía que mantener el equilibrio para no caer. \n" +
                "La fuerza de la corriente lo empujaba constantemente, haciendo que cada paso fuera una lucha. \n" +
                "En un momento, se vio obligado a aferrarse a una rama que sobresalía para evitar ser arrastrado por el agua. \n" +
                "Con un esfuerzo titánico, logró finalmente llegar a la otra orilla, exhausto pero triunfante.\n" +
                "Decidió descansar bajo un árbol cercano, donde se acomodó para pasar la noche. El cielo estaba estrellado y el silencio del bosque era interrumpido solo por el murmullo del río.\n" +
                "A la mañana siguiente, al despertar, notó algo brillante en un hueco de un árbol cercano. Se acercó para investigar y descubrió un cofre antiguo cubierto de musgo. \n" +
                "El cofre tenía un aspecto desgastado y antiguo, como si hubiera estado allí durante mucho tiempo, esperando ser encontrado. \n" +
                "Al inentar abrirlo, descubrió un acertijo inscrito en la tapa del cofre:\n"
            );
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Resuelve el acertijo para abrir el cofre:");
            Console.ResetColor();
            Console.WriteLine("¿Qué número es mayor que 5 pero menor que 10, y si lo multiplicas por 2 obtienes 14?");
            string respuesta = Console.ReadLine();
            if (respuesta == "7")
            {
                MostrarFinalRio();
            }
            else
            {
                Console.WriteLine(
                    "El aventurero intentó resolver el acertijo con gran esfuerzo, pero la respuesta no era correcta. \n" +
                    "Incrédulo, observó cómo el cofre que había encontrado comenzaba a desvanecerse en una nube de humo. \n" +
                    "El cofre desapareció, y el humo envolvió el área, dejando solo un vago brillo en el aire. \n" +
                    "El aventurero se quedó mirando el lugar donde el cofre había estado, con una sensación de desilusión. \n" +
                    "Sin el tesoro y con el corazón pesado, decidió vagar por el bosque, resignado a aceptar que su sueño de niño era solo eso, un sueño.\n" +
                    "\n" +
                    "Mientras caminaba sin rumbo, sintiendo auún el gran golpe de su fracaso, una criatura fantástica conocida como el \n" +
                    "‘Fénix de la Niebla’, un ser de aspecto etéreo con alas doradas y ojos brillantes, lo observó desde entre los árboles. \n" +
                    "Al ver la tristeza en el rostro del aventurero, el Fénix se sintió conmovido y decidió ayudarlo. \n" +
                    "Se acercó con cautela y, con un gesto mágico, dibujó en la tierra un sendero luminoso que brillaba tenuemente en la oscuridad del bosque. \n" +
                    "El Fénix habló con una voz suave y tranquilizadora: ‘Sigue este camino, te llevará de vuelta a casa’. \n" +
                    "Agradecido por la ayuda inesperada, el aventurero siguió el sendero con la esperanza de volver a su hogar. \n");
                MostrarRegresoSinTesoro();
            }
        }

        public static void MostrarOpcionCasa()
        {
            Console.WriteLine(
                    "El aventurero se acercó a la casa, que parecía desierta y abandonada. La estructura estaba cubierta de musgo \n" +
                    "y las ventanas estaban rotas. Al entrar, el aire estaba denso y el polvo cubría cada rincón. \n" +
                    "Comenzó a explorar con cuidado, encontrando muebles antiguos cubiertos de telarañas y estanterías llenas de libros polvorientos. \n" +
                    "En una esquina, encontró una vieja mesa con objetos desordenados: una brújula rota, un reloj de arena sin arena, \n" +
                    "y varias cartas arrugadas que parecían no tener importancia. En el suelo, había un baúl deteriorado, pero al abrirlo, \n" +
                    "solo encontró ropa desgastada y algunos trastos viejos. \n\n" +
                    "Finalmente, en una estantería en el rincón más oscuro, descubrió un libro antiguo cubierto de polvo. \n" +
                    "Al abrir el libro, un lápiz apareció de su interior, como si estuviera esperando ser encontrado. \n" +
                    "Con curiosidad, el aventurero escribió en el libro con el lápiz, y en el apareció:\n");

            Console.WriteLine();
            Console.WriteLine(
                "“En la cima de una montaña alta, \n" +
                "donde el viento sopla con gran fuerza, \n" +
                "busca una grieta que es la clave, \n" +
                "allí el tesoro se encuentra escondido, \n" +
                "si eres valiente, lo hallarás.”\n");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("¿Qué hará nuesto aventurero?");
            Console.ResetColor();

            Console.WriteLine(
                "1. Buscaré la montaña\n" +
                "2. Me detenerse y regrwsar a casa\n");

            string decision = Console.ReadLine();
            if (decision == "1")
            {
                MostrarMontaña();
            }
            else
            {
                Console.WriteLine(
                    "El aventurero decidió no seguir buscando y dejó la casa, para volver a la suya. \n");
                MostrarRegresoSinTesoro();
            }
        }

        public static void MostrarMontaña()
        {
            Console.WriteLine(
                    "El aventurero se dispuso a encontrar la montaña más alta del bosque. \n" +
                    "El camino hacia la montaña no fue fácil. Tuvo que atravesar terrenos abruptos y escarpados. \n" +
                    "Al principio, caminó a través de bosques densos donde los árboles parecían formar un laberinto natural. \n" +
                    "Las ramas se enredaban en su ropa y los arbustos espinosos dificultaban su avance. \n" +
                    "Además, enfrentó lluvias intensas que hicieron los senderos resbaladizos y el barro complicó su progreso. \n\n" +
                    "A medida que se acercaba a la montaña, el clima se volvió más hostil. Las temperaturas descendieron drásticamente, \n" +
                    "y los vientos helados soplaban con fuerza, casi impidiendo que avanzara. \n" +
                    "Tuvo que hacer pausas frecuentes para calentarse y protegerse del frío. \n\n" +
                    "Finalmente, llegó a la base de la montaña. La imponente elevación se alzaba frente a él, con sus picos cubiertos de nieve \n" +
                    "y paredes rocosas que parecían desafiar a cualquier escalador. Un anciano sabio apareció de entre las sombras y le advirtió:\n" +
                    "“Esta montaña nunca ha sido escalada por nadie. Muchos han intentado y han fallado. Algunos incluso han perdido la vida.”\n");
            Console.WriteLine();

            Console.WriteLine(
                    "Con gran esfuerzo y determinación, el aventurero comenzó a escalar la montaña. \n" +
                    "El ascenso fue arduo y desafiante. Enfrentó terrenos escarpados y rocosos, \n" +
                    "donde cada paso debía ser cuidadosamente calculado para evitar caer. La escalada se volvió aún más difícil \n" +
                    "a medida que las temperaturas descendían y el viento se intensificaba. \n" +
                    "A lo largo del camino, encontró grietas traicioneras y paredes rocosas que parecían imposibles de superar.\n" +
                    "El aventurero utilizó herramientas improvisadas y su ingenio para superar los obstáculos. Finalmente, llegó a la cima.\n" +
                    "En la cumbre, descubrió una antigua estructura de piedra, parcialmente cubierta por musgo y enredaderas. \n" +
                    "El aventurero se acercó a la estructura y notó que en su interior había una entrada oculta.\n" +
                    "Dentro de la estructura, encontró un cofre antiguo cubierto de polvo y telarañas. En la tapa del cofre había un grabado con un acertijo:\n\n" +
                    "“Soy ligero como una pluma, pero ni el hombre más fuerte puede sostenerme por mucho tiempo. \n" +
                    "¿Qué soy?”\n");

            Console.Write("Escribe tu respuesta: ");
            string respuesta = Console.ReadLine();

            if (respuesta.Trim().ToLower() == "respiración" || respuesta.Trim().ToLower() == "respiracion")
            {
                Console.WriteLine(
                    "El acertijo fue resuelto correctamente. \n" +
                    "El aventurero pudo abrir el cofre, revelando el Tesoro Perdido, que resplandecía con una luz dorada, iluminando el oscuro bosque, \n"
                    "por lo que al salir de la cueva pudo encontrar el camino de vuelta a casa, esta vez sin dificultades ni desafíos." +
                    "Había superado todas las pruebas y desvelado el tesoro escondido. Su alegría era inmensa.\n");
                MostrarRegresoConTesoro();
            }
            else
            {
                Console.WriteLine(
                    "El acertijo no fue resuelto correctamente. \n" +
                    "Incrédulo, el aventurero vio cómo el cofre comenzaba a desmoronarse al mismo tiempo que el suelo bajo él se quebraba. \n" +
                    "El cofre se desmoronó y se rompió en pedazos, mientras el aventurero, aterrorizado, vio cómo el suelo se desintegraba.\n" +
                    "Corrió por su vida, tratando de escapar del acantilado que se abría ante él, pero no tuvo éxito. \n" +
                    "Cayó en un profundo abismo, y a pesar de sus esfuerzos por encontrar una salida, no pudo escapar de la oscuridad del acantilado.\n");
            }
        }

        public static void MostrarFinalRio()
        {
            Console.WriteLine(
                "Al abrir el cofre, encontró el Tesoro Perdido que tanto había anhelado. \n" +
                "Su resplandor iluminaba toda la oscuridad del bosque como un día soleado. \n" +
                "El aventurero había encontrado lo que muchos habían buscado en vano. \n" +
                "Su felicidad era inmensa. \n\n" +
                "Decidido a regresar a casa con su hallazgo, el aventurero buscó una manera de salir del bosque. \n" +
                "Siguiendo un rastro de luz que parecía guiado por la magia del tesoro, encontró un sendero que no había visto antes. \n" +
                "El sendero estaba adornado con piedras brillantes que reflejaban la luz del tesoro, iluminando el camino. \n" +
                "A medida que avanzaba, el bosque parecía despejarse, y los árboles se abrían para revelar un camino claro hacia la salida. \n" +
                "Finalmente, emergió del bosque, dejando atrás el misterio y el peligro.\n");
            MostrarRegresoConTesoro();
        }


        public static void MostrarFinalMontaña()
        {
            Console.WriteLine(
                "Con gran esfuerzo y determinación, el aventurero escaló la montaña. \n" +
                "En la cima, encontró una grieta y dentro de ella el Tesoro Perdido del bosque frondoso. \n" +
                "Había superado todas las pruebas y desvelado el tesoro escondido.\n");
            MostrarRegresoConTesoro();
        }

        public static void MostrarRegresoConTesoro()
        {
            Console.WriteLine();
            Console.WriteLine(
                "El aventurero regresó al pueblo con el Tesoro Perdido, trayendo consigo una gran alegría y admiración. \n" +
                "La noticia de su hazaña se extendió rápidamente, alcanzando otros pueblos y regiones. \n" +
                "La gente del pueblo lo vio como un héroe legendario. Su historia de valentía y determinación se convirtió en una \n" +
                "leyenda que inspiró a muchos. \n" +
                "El aventurero utilizó el tesoro para mejorar la vida de los habitantes del pueblo, \n" +
                "invirtiendo en infraestructuras, salud y educación. El pueblo se volvió más próspero y unido. \n" +
                "Los escépticos, que antes dudaban de la existencia del tesoro y del valor de su búsqueda, \n" +
                "se sorprendieron y comenzaron a reconocer la valía del aventurero. Algunos se sintieron inspirados y \n" +
                "cambiaron su actitud hacia las leyendas y las aventuras. \n" +
                "Cada día, nuevos aventureros se aventuraban al bosque, esperanzados en repetir la hazaña del héroe. \n" +
                "El bosque, antes temido y desalentador, se convirtió en un símbolo de esperanza y valentía. \n" +
                "El éxito del aventurero no solo cambió su vida, sino que dejó una marca indeleble en la historia del pueblo \n"
                + "y en el corazón de quienes escucharon su historia.\n");

        }

        public static void MostrarRegresoSinTesoro()
        {
            Console.WriteLine();
            Console.WriteLine(
                "El aventurero regresó al pueblo sin el tesoro. \n" +
                "Aunque había enfrentado muchos desafíos y había visto el cofre que prometía el gran premio, \n" +
                "no encontró el tesoro final. La gente del pueblo le ofreció consuelo y admiración por su valentía, \n" +
                "pero no pudieron evitar recordarle que ya se lo habían advertido antes. \n" +
                "La historia de su búsqueda se convirtió en una lección sobre la perseverancia y el valor, inspirando a otros a seguir sus pasos. \n" +
                "A pesar del apoyo, muchos en el pueblo no dejaron de comentar que el aventurero había sido imprudente \n" +
                "y que el tesoro del bosque era solo una leyenda. \n" +
                "Aunque su historia no fue del todo creída, aquellos que habían visto el brillo en sus ojos cuando hablaba del cofre \n" +
                "lo tomaron como un ejemplo de determinación. A pesar de no haber logrado encontrar el tesoro, el aventurero continuó con sus aventuras, \n" +
                "pero nunca pudo recuperar la misma emoción que sintió en el bosque. \n" +
                "Aún así, su experiencia quedó grabada en la memoria de los habitantes del pueblo, \n" +
                "y su historia se convirtió en una fuente de inspiración para aquellos que se atreven a soñar más allá de las leyendas. \n" +
                "El hecho de que él hubiera visto el cofre y enfrentado los desafíos del bosque aún daba esperanza a quienes se aventuraban \n" +
                "a buscar el tesoro, sabiendo que, al menos, había alguien que había estado tan cerca de encontrarlo.\n");

        }
    }
}
