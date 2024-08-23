using System;
using System.Runtime.Intrinsics.X86;

namespace arbolbinario
{
    internal class Historia
    {
        public static void EscribirHistoria(int nNodo)
        {
            switch (nNodo)
            {
                case 1:
                    MostarInicio();
                    break;
                case 2:
                    IrAlRío();
                    break;
                case 3:
                    IrALaCasa();
                    break;
                case 4:
                    AciertaAcertijoRio();
                    break;
                case 5:
                    FallaAcertijoRio();
                    break;
                case 6:
                    DetenerseYVolver();
                    break;
                case 7:
                    BuscarMontaña();
                    break;
                case 8:
                    DetenerseYVolver();
                    break;
                case 9:
                    EscalarMontaña();
                    break;
                case 10:
                    AciertaAcertijoMontaña();
                    break;
                case 11:
                    FallaAcertijoMontaña();
                    break;
                default:
                    break;
            }
        }

        #region Texto de la historia

        private static void MostarInicio()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\t \t \t \t VAMOS A BUSCAR UN TESORO\n");
            Console.ResetColor();
            Console.WriteLine(
                "\t En algún lugar del mundo, en un sitio lejano y envuelto en misterio, se encuentra el peculiar \n" +
                "Bosque Frondoso. Este bosque es famoso por sus historias mágicas y secretos ancestrales que han  \n" +
                "cautivado la imaginación de las personas durante siglos. Las leyendas hablan de creaturas místicas, \n" +
                "escenarios naturales increíbles, senderos que cambian de forma... pero hay una cosa que resalta entre \n" +
                "las demás: un tesoro escondido. Este tesoro ha sido un premio codiciado por muchos a lo largo de la \n" +
                "historia, pero ninguno ha logrado regresarlo al mundo conocido. A través de los años, las historias \n" +
                "sobre aventureros se adentran en este lugar buscando el tesoro no paran de crecer, llenas de valentía \n" +
                "y algunas de desgracia. \n" +
                "\t Los que se atreven a adentrarse en él son frecuentemente objeto de críticas en Villa Frondesa, pueblo\n" +
                "más cercano al bosque, porque aquí han sido testigos en primera persona de locales y gente de \n" +
                "otros pueblos a quienes se ha visto entrar al bosque pero nunca salir. Se les considera avariciosos,  \n" +
                "temerarios por intentar desentrañar un misterio que ha desafiado a tantas generaciones sin éxito. \n" +
                "Habitantes del pueblo, con una mezcla de escepticismo y desdén, se burlan de aquellos que buscan el \n" +
                "tesoro, llamándolos soñadores imprudentes que arriesgan sus vidas por un mito.\n" +
                "\t Desde su infancia, el Finn, un joven aventurero del pueblo había escuchado estas historias y sobre todo \n" +
                "comentarios negativos sobre el bosque. En lugar de desanimarlo, estas lo que escuchaba únicamente hacía \n" +
                "que creciera en él su esíritu curioso y la imaginación de sus sueños de adentrarse a explorar en el bosque. \n" +
                "pues siempre ha deseado ser él quien se adentrase en el bosque y regrese con el tesoro que tantos \n" +
                "habían buscado en vano. Con la esperanza de mejorar la vida en su muy humilde y sencillo pueblo. \n" +
                "Su espíritu aventurero lo llevó a explorar todos los alrededor del pueblo. Con el tiempo, todas las \n" +
                "aventuras locales se volvieron familiares y predecibles, dejando solo un gran desafío por enfrentar: el \n" +
                "enigmático Bosque Frondoso. Finalmente, decidió que era el momento de buscar su sueño y entrar en el \n" +
                "bosque, listo para a enfrentar los desafíos y descubrir si el tesoro era más que una simple leyenda.\n");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(
                "\t Con gran determinación, Finn emprendió su camino hacia el Bosque Frondoso. A medida que adentraba entre, \n" +
                "sus árboles, el ambiente se volvía más denso. Una niebla comenzaba a envolverlo, haciendo que su visibilidad  \n" +
                "disminuyera casi por completo. Los susurros del viento resonaban a su alrededor, como si el bosque le hablara \n" +
                "en un idioma propio. Cada crujido de las ramas y cada sombra que se movía entre los árboles aumentaba su \n" +
                "inquietud, pero también su curiosidad.\n" +
                "Mientras continuaba caminando, el terreno se volvía cada vez más irregular. Las raíces de los árboles se \n," +
                "se entrelazaban al rededor de sus pies como si quisieran atraparlo, algunas incluso se movían de forma que \n," +
                "formaban obstáculos como muros en su camino. El aire estaba cargado con el olor a humedad y musgo. \n" +
                "En ciertos tramos, el sendero se estrechaba casi hasta desaparecer, mientras que en otros se abrían claros \n" +
                "donde los altos árboles se alzaban como gigantes que vigilaban su paso.\n" +
                "Eran estos los pasajes del bosque que le permitían apreciar la belleza del lugar, al ser más tranquilos y \n" +
                "permitirle ver mejor con la ausencia de niebla. Aquí es donde Finn disfrutaba de su viaje pues al observar \n" +
                "los paisajes, las plantas con formas y colores tan peculiares, además de varias criaturas que consideraba mitos \n" +
                "como hadas, unicorios y duendes paseandose por lo que es su hogar.\n" +
                "El aventurero conversó con varias craturas en busca de alguna pista sobre el tesoro, pero nadie le supo dar \n" +
                "algún indicio, solamente intercambiaban anécdotas de cómo es la vida en mundos tan diferentes. Mientras \n" +
                "se paseaba por el lugar, fin logró ver varios rótulos de que se prohibía la entrada a los trolls, lo que " +
                "llamó su atención, debido a que nadie le mencionó nada relacionado a ellos.\n" +
                "Al continuar con su camino, finalmente llegó a un cruce de caminos donde debía tomar una decisión importante. \n" +
                "Por un lado, un río caudaloso se lograba apreciar apreciar a lo lejos, con el ruido de una corriente que rugía\n" +
                "con un fuerte estruendo. Al otro lado, a su derecha, se veía una casa antigua y aparentemente abandonada, con\n" +
                "ventanas rotas, despintada y una puerta que se movía levemente con el viento. " +
                "Finn tenía que decidir si arriesgarse a cruzar el río para continuar explorando o investigar la casa en busca\n" +
                "de pistas, era momento de elegir el camino para continuar su búsqueda del tesoro");
        }

        public static void IrAlRío()
        {
            Console.WriteLine(
                "El aventurero decidió tomar el camino que llevaba hacia el río, al avanzr por el sendero el camino por el que \n. " +
                "Avanzó hace segundos se iba cerrando a sus espaldas, no había vuelta atrás. Con cada paso el ruido de la \n" +
                "poderosa corriente se volvía más ensordecedor. Finn comenzaba a preguntarse si el reto que lo esperaba al final \n" +
                "de sendero, podría doblegar su determinación. \n" +
                "Continuó atravesando el sendero, a medida que se volvía más dificil de atravesar. El suelo por el que caminaba solo \n" +
                "era un espeso barro en el que sus pies se hundían, la humedad de la zona creaba condiciones en las cuáles su cuerpo \n" +
                "sentía un calor increíble. Deshidratado por el bochorno y el camino, estaba desesperado por llegar al borde del río \n" +
                "para poder beber de su agua.\n" +
                "Pasados unos minutos, por fin logró llegar a un lugar abierto donde se podía ver el río y nuevamente el paisaje con \n" +
                "mayor amplitud. Finn bebió agua y aprovechó para descansar en la orilla, pensando cómo ingeniarselas para lograr\n" +
                "cruzar al otro lado. Él, acostado en el suelo viendo hacia un cielo lleno de auras boreales, recordaba aquellos tiempos\n" +
                "en los que tanto deseaba estar en este lugar, que pese a varias dificultades le seguía pareciendo lo más bello que ha\n" +
                "visto. Nuestro viajero se quedó dormido, hasta que un ruido extraño se diferenció del gran sonido que hacía la\n" +
                "la corriente. Se sentó, miró a su alrededor para aún medio dormido intentar comprender que era lo que estaba pasando. \n" +
                "Escuchaba pasos que hacían temblar el suelo. Prestó a atención a unos puntitos que se veían en el horizonte y tras" +
                "forzar un poco la vista, lo comprendió. Era una estampida de Centauros que venían hacia él. Finn, asustado recogió \n" +
                "sus cosas para irse del lugar y comenzó a correr por la orilla bucando evadir lo que se le acercaba.\n" +
                "Corrió y conrrió sin embargo la estampida lo alcanzaba por una mayor velocidad, creyó que su única salida era cruzar \n" +
                "al otro lado, confiando en que resisitiría la corriente.\n");
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(
                "Decidido a cruzar el río, el aventurero avanzó con cautela, pero subestimó la fuerza de la corriente. \n" +
                "Al dar un paso en falso, el agua lo arrastró con una fuerza abrumadora, nadó y nadó pero ya era tarde, \n" +
                "Entre frío y caos, intió que su cuerpo era llevado sin control por el río, hasta que finalmente fue arrojado \n" +
                "a la orilla en un lugar desconocido, agotado pero ileso. \n" +
                "Al levantarse, se encontró en un rincón del bosque que no había visto antes. Finn se sintió perdido, no había" +
                "forma de ubicarse e intentar volver por donde había venido. Desilusionado, caminó sin rumbo por días, hasta" +
                "que en su desesperación empezó golpear con todas sus fuerzas un árbol por el que iba pasando. Era uno muy\n" +
                "antiguo, luego de descargar su frustración sobre él, alzó la cabeza y notó que el árbol destacaba entre los demás, \n" +
                "era distinto. Vioó que sus golpes hicieron un pequeño hueco en su tronco por el que emanaba un brillo tenue \n" +
                "y misterioso. \n" +
                "Intrigado, terminó de romper el tronco y, al inspeccionar el hueco, descubrió un cofre viejo cubierto de musgo. \n" +
                "Lo abrió con cuidado y en uno de los bordes del cofre encontró un acertijo tallado en la madera, que \n" +
                "parecía ser la clave para desvelar el siguiente secreto de su aventura.\n");
            Console.WriteLine("¿Qué número es mayor que 5 pero menor que 10, y si lo multiplicas por 2 obtienes 14?");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Resuelve el acertijo para abrir el cofre:");
            Console.ResetColor();
        }

        static void FallaAcertijoRio()
        {
            Console.WriteLine(
                    "El aventurero intentó resolver el acertijo con gran esfuerzo, pero la respuesta no era correcta. \n" +
                    "Incrédulo, observó cómo el cofre que había encontrado comenzaba a desvanecerse en una nube de humo. \n" +
                    "El cofre desapareció, y el humo envolvió el área, dejando solo un vago brillo en el aire. \n" +
                    "El aventurero se quedó mirando el lugar donde el cofre había estado, con una sensación de desilusión. \n" +
                    "Sin el tesoro y con el corazón pesado, decidió vagar por el bosque, resignado a aceptar que su sueño de " +
                    "niño era solo eso, un sueño.\n" +
                    "Mientras caminaba sin rumbo, sintiendo auún el gran golpe de su fracaso, una criatura emergió de entre \n" +
                    "los árboles y se le acercó, se hacía llamar ‘El Fénix de la Niebla’, un ser de aspecto etéreo con alas \n" +
                    "doradas y ojos brillantes, lo observó desde entre los árboles. Al ver la tristeza el rostro del aventurero \n" +
                    "lo había comenzado a seguir hacía ya varias horas horas. Intercambiaron una conversación, el Fénix tras \n" +
                    "tras escuchar toda la de Finn sobre lo que había ocurrido, la razón de su desánimo, se sintió conmovido y " +
                    "decidió ayudarlo. \n" +
                    "Se acercó con cautela y, con un gesto mágico, dibujó en la tierra un sendero luminoso que brillaba tenuemente \n" +
                    "en la oscuridad del bosque. \n" +
                    "El Fénix habló con una voz suave y tranquilizadora: ‘Lo hiciste bien. Sigue este camino, te llevará de vuelta a casa’. \n" +
                    "Agradecido por la ayuda inesperada, el aventurero siguió el sendero con la esperanza de volver a su hogar. \n");

            MostrarRegresoSinTesoro();
        }

        static void FallaAcertijoMontaña()
        {
            Console.WriteLine(
                "El acertijo no fue resuelto correctamente. \n" +
                "Incrédulo, el aventurero vio cómo el cofre comenzaba a desmoronarse al mismo tiempo que el suelo bajo él se quebraba. \n" +
                "El cofre se desmoronó y se rompió en pedazos, mientras el aventurero, aterrorizado, vio cómo el suelo se desintegraba.\n" +
                "Corrió por su vida, tratando de escapar del acantilado que se abría ante él, pero no tuvo éxito. \n" +
                "Cayó en un profundo abismo, y a pesar de sus esfuerzos por encontrar una salida, no pudo escapar de la oscuridad del acantilado.\n" +
                "Nunca más se volvió a saber de Finn en Villa Frondosa...");
        }

        public static void AciertaAcertijoRio()
        {
            Console.Clear();
            Console.WriteLine(
                "Finn acertó el acertijo. \n"+
                "Al abrir el cofre, sintió cómo su corazón latía con fuerza, cada vez más rápido. Frente a él, el Tesoro Perdido \n" +
                "brillaba con una intensidad que casi cegaba, como si todo el bosque se hubiera reunido para presenciar el momento. \n" +
                "El resplandor dorado iluminaba todo a su alrededor, se pareciera a un paraíso bañado por la luz del sol. Pero lo que \n" +
                "más le sorprendió no fue la luz, sino el contenido del cofre: un líquido dorado que se movía suavemente.\n" +
                "Finn, sumergió la mano en el líquido. Al sacar un puñado, observó con asombro cómo, al caer y tocar el suelo \n" +
                "el líquido se transformaba en oro sólido, brillante y pesado. Era oro puro, el sueño de cualquier aventurero, y \n" +
                "lo más sorprendente es que no importaba cuánto líquido sacara del cofre, este nunca parecía disminuir. \n" +
                "Por un momento, Finn se quedó sin aliento, atrapado entre la maravilla y el temor. Mientras lo contemplaba, pensamientos \n" +
                "fugaces cruzaron su mente: la vida que podría tener con este tesoro, cómo podría cambiar la suerte de su humilde pueblo, \n" +
                "cómo todos aquellos que se burlaron de él en Villa Frondesa quedarían asombrados. \n" +
                "Decidido a no perder más tiempo, Finn recogió lo que pudo y comenzó a buscar camino para regresar a casa. Sin embargo, \n" +
                "el bosque parecía haber cambiado. A medida que avanzaba, un sendero que no había visto antes apareció frente a él, como \n" +
                " si el propio bosque estuviera guiándolo. Las piedras del camino brillaban con la misma intensidad que el oro que llevaba,\n +" +
                "mostrando el camino a seguir. Era como si el bosque lo estuviera despidiendo, abriendo sus brazos para permitirle salir.\n" +
                "Finalmente, tras lo que le pareció una eternidad, Finn emergió del bosque. La luz del día lo recibió con calidez, y por \n" +
                "un momento, se sintió aliviado, libre del misterio y el peligro que el Bosque Frondoso representaba.\n"
            );
            MostrarRegresoConTesoro();
        }

        public static void AciertaAcertijoMontaña()
        {
            Console.Clear();
            Console.WriteLine(
                "El acertijo fue resuelto correctamente. \n" +
                "El aventurero pudo abrir el cofre, revelando el Tesoro Perdido, que resplandecía \n" +
                "con una luz dorada, iluminando el oscuro bosque, por lo que al salir de la cueva \n " +
                "pudo encontrar el camino de vuelta a casa, esta vez sin dificultades ni desafíos. \n" +
                "Había superado todas las pruebas y desvelado el tesoro escondido, su sueño se había \n" +
                "hecho realidad, no podía contener su alegría, caminaba ansioso pensando en la \n" +
                "reación del pueblo a su gran logro y cómo tenía una herramienta para cambiar" +
                "la vida de todos\n");
            MostrarRegresoConTesoro();
        }

        public static void IrALaCasa()
        {
            Console.WriteLine(
                    "El aventurero se acercó a la casa, que parecía desierta y abandonada. La estructura estaba cubierta de musgo \n" +
                    "y las ventanas estaban rotas. Al entrar, el aire estaba denso y el polvo cubría cada rincón. \n" +
                    "Comenzó a explorar con cuidado, encontrando muebles antiguos cubiertos de telarañas y estanterías llenas de \n" +
                    "libros polvorientos. En una esquina, encontró una vieja mesa con objetos desordenados: una brújula rota, un \n" +
                    "reloj de arena sin arena, y varias cartas arrugadas que parecían no tener importancia. En el suelo, había un \n " +
                    "baúl deteriorado, pero al abrirlo, solo encontró ropa desgastada y algunos trastos viejos. Estaba a punto de \n" +
                    "irse de la casa hata que detrás de una puerta, en una estantería tapada por una manta, descubrió un libro " +
                    "antiguo cubierto de polvo. Al abrir el libro, un lápiz apareció de su interior, como si estuviera esperando \n" +
                    "ser encontrado. Con curiosidad, el aventurero escribió en el libro con el lápiz, y en el apareció:");

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
                "2. Me detenerse y regresar a casa\n");

            string decision = Console.ReadLine();
            if (decision == "1")
            {
                BuscarMontaña();
            }
            else
            {
                Console.WriteLine(
                    "El aventurero decidió no seguir buscando y dejó la casa, para volver a la suya. \n");
                MostrarRegresoSinTesoro();
            }
        }

        public static void BuscarMontaña()
        {
            Console.WriteLine(
                    "El aventurero se dispuso a encontrar la montaña más alta del bosque. \n" +
                    "El camino hacia la montaña no fue fácil, tuvo que atravesar terrenos abruptos y escarpados. \n" +
                    "Al principio, caminó a través de bosques densos donde los árboles parecían formar un laberinto \n" +
                    "natural, las ramas se enredaban en su ropa y los arbustos espinosos dificultaban su caminar. \n" +
                    "Además, enfrentó lluvias intensas que hicieron los senderos resbaladizos y esto complicó su progreso. \n" +
                    "A medida que se acercaba a la montaña, el clima se volvió más hostil. Las temperaturas descendieron \n" +
                    "drásticamente, y los vientos helados soplaban con fuerza, casi impidiendo que avanzara. \n" +
                    "Tuvo que hacer pausas frecuentes para calentarse y protegerse del frío. Hasta que, consiguió \n" +
                    "llegar a la base de la montaña. La imponente elevación se alzaba frente a él, con sus picos \n" +
                    "cubiertos de nieve apenas eran visibles por la gran osuridad de provocada por la intensa lluvia lo \n" +
                    "que si se le presentaba claro como el agua, eran las paredes rocosas que parecían desafiar capaces \n" +
                    "de desafiar a cualquier escalador, incluso el má hábil. Un anciano sabio apareció de entre la osuridad" +
                    "y la lluvia, este simplemente se acercó y le advirtió:\n" +
                    "“Esta montaña nunca ha sido escalada por nadie. Muchos han intentado y han fallado. Algunos incluso han perdido la vida.”\n");
            Console.WriteLine();
        }

        public static void DetenerseYVolver()
        {
            Console.WriteLine(
                   "El viajero, después de enfrentar numerosos desafíos y con el peso de la frustración \n" +
                   "en su corazón, decidió que ya no podía continuar. Con la esperanza hecha trizas, comenzó \n" +
                   "a retroceder sobre sus pasos, pero pronto se dio cuenta de que el bosque no se lo permitiría \n" +
                   " tan fácilmente. \n" +
                   "Lo que antes era un sendero ahora estaba envuelto en una niebla espesa y fría. Perdido y sin \n" +
                   "rumbo, vagó durante días que se convirtieron en semanas, hasta que finalmente los días se \n" +
                   "transformaron en años. Durante este tiempo, se topó con otros viajeros que, al igual que él, \n" +
                   "habían intentado desafiar al Bosque Frondoso. \n" +
                   "Se unió a ellos, formando un grupo de almas perdidas que se apoyaban mutuamente en su desesperación. \n" +
                   "Juntos, buscaban la salida, pero siempre terminaban caminando en círculos, atrapados en el \n" +
                   "laberinto verde y misterioso. Con el tiempo, el grupo se resignó a su destino, convirtiéndose en \n" +
                   "una comunidad aislada, subsistiendo con lo que el bosque les ofrecía. \n" +
                   "Nunca más se supo de ellos, y en el pueblo, el viajero pasó a ser otra advertencia, un recordatorio\n" +
                   "sombrío de por qué no se debía desafiar al bosque. Sus nombres se perdieron en las sombras del tiempo, \n" +
                   "y el Bosque Frondoso continuó siendo un lugar de leyendas y temor, guardando sus secretos para siempre.\n");
        }

        public static void PerdidoEnElbosque()
        {
            Console.WriteLine(
                    "El aventurero se dispuso a encontrar la montaña más alta del bosque. \n" +
                    "El camino hacia la montaña no fue fácil, tuvo que atravesar terrenos abruptos y escarpados. \n" +
                    "Al principio, caminó a través de bosques densos donde los árboles parecían formar un laberinto \n" +
                    "natural, las ramas se enredaban en su ropa y los arbustos espinosos dificultaban su caminar. \n" +
                    "Además, enfrentó lluvias intensas que hicieron los senderos resbaladizos y esto complicó su progreso. \n" +
                    "A medida que se acercaba a la montaña, el clima se volvió más hostil. Las temperaturas descendieron \n" +
                    "drásticamente, y los vientos helados soplaban con fuerza, casi impidiendo que avanzara. \n" +
                    "Tuvo que hacer pausas frecuentes para calentarse y protegerse del frío. Hasta que, consiguió \n" +
                    "llegar a la base de la montaña. La imponente elevación se alzaba frente a él, con sus picos \n" +
                    "cubiertos de nieve apenas eran visibles por la gran osuridad de provocada por la intensa lluvia lo \n" +
                    "que si se le presentaba claro como el agua, eran las paredes rocosas que parecían desafiar capaces \n" +
                    "de desafiar a cualquier escalador, incluso el má hábil. Un anciano sabio apareció de entre la osuridad" +
                    "y la lluvia, este simplemente se acercó y le advirtió:\n" +
                    "“Esta montaña nunca ha sido escalada por nadie. Muchos han intentado y han fallado. Algunos incluso han perdido la vida.”\n");
            Console.WriteLine();
        }

        public static void EscalarMontaña()
        {
            Console.WriteLine(
                    "Con gran esfuerzo y determinación, el aventurero comenzó a escalar la montaña. \n" +
                    "El ascenso fue arduo y desafiante. Enfrentó terrenos escarpados y rocosos, \n" +
                    "donde cada paso debía ser cuidadosamente calculado para evitar caer. La escalada \n " +
                    "se volvió aún más difícil a medida por la altura que las temperaturas descendían " +
                    "aún más pese haber cesado la lluvia. El viento se intensificaba y se empezaba a" +
                    "sentir una leve falta de oxígeno por la elevación. \n" +
                    "A lo largo del camino, encontró grietas traicioneras, en algunas incluso llegó a \n" +
                    "resbalar, pero él se aferraba sabiendo que no tenía más remedio que llegar a la" +
                    "cima de la montaña. \n" +
                    "El aventurero utilizó palos, pequeñas rocas improvisadas y tuvo que llevar su \n" +
                    "ingenio al límite para superar poco a poco cada una de las partes del ascenso.\n" +
                    "Luego de varias horas de escalada, por fin llegó a llegó a la cima donde esperaba" +
                    "darse vuelta y encontrar una espectaculares vistas del bosque desde lo alto, pero" +
                    "las nubes de la lluvia aún le tapaban la vista.\n" +
                    "Explorando la cumbre, descubrió una antigua estructura de piedra, parcialmente \n" +
                    "cubierta por musgo y enredaderas. Finn se acercó a la estructura y notó que en su" +
                    "interior había una entrada oculta.\n" +
                    "Dentro de la estructura, encontró un cofre antiguo cubierto de polvo y telarañas. \n" + 
                    "En la tapa del cofre había un grabado con un acertijo:\n\n" +
                    "“Soy ligero como una pluma, pero ni el hombre más fuerte puede sostenerme por mucho tiempo. \n" +
                    "¿Qué soy?”\n");



            MostrarRegresoConTesoro();
        }

        public static void MostrarRegresoConTesoro()
        {
            Console.WriteLine(
                "El aventurero, regresó al pueblo con el Tesoro Perdido, trayendo consigo no solo riqueza, \n" +
                "sino una nueva esperanza. La noticia de su hazaña se esparció como el viento, alcanzando \n " +
                "incluso las aldeas más lejanas. \n" +
                "En Villa Frondesa, la gente lo recibió como un héroe, con ojos llenos de admiración y corazones que antes dudaban, \n" +
                "pero ahora reconocían su valentía. Con el tesoro, Finn transformó el pueblo: las calles polvorientas se pavimentaron, \n" +
                "se construyeron nuevas escuelas, casas para sus habitantes, se mejoraron los servicios del pueblo y la gente, antes \n" +
                "desalentada, comenzó a soñar de nuevo. El bosque, una vez temido por lo desconocido, se volvió un lugar de curiosidad \n" +
                "y respeto. Los árboles que antes susurraban misterios ahora contaban historias de valentía a aquellos que se aventuraban \n" +
                "en sus profundidades. Otros aventureros, inspirados por Finn, se adentraron en el bosque, aunque ninguno volvió con un \n" + 
                "tesoro igual, el legado de Finn no solo estaba en el oro que trajo, sino en la fuerza y unidad que sembró en su gente. \n" +
                "El pueblo floreció, y Finn, aunque siempre humilde, supo que su historia no sería olvidada. \n" +
                "El bosque, antes un lugar mal visto, se convirtió en un símbolo de la luz que un corazón valiente puede traer al mundo.\n");
        }


        public static void MostrarRegresoSinTesoro()
        {
            Console.WriteLine();
            Console.WriteLine(
                "El aventurero regresó al pueblo sin el tesoro. \n" +
                "Aunque había enfrentado muchos desafíos y había visto el cofre que prometía el gran premio, no\n" +
                "encontró el tesoro final. Sus amigos del pueblo le ofrecieron consuelo y admiración por su valentía, \n" +
                "pero los otros, los escépticos, no pudieron evitar recordarle que ya se lo habían advertido antes. \n" +
                "Muchos en el pueblo no dejaron de comentar que el aventurero había sido imprudente y que el tesoro del \n" +
                "bosque era solo una leyenda. Aunque su historia no fue del todo creída, para aquellos que habían visto el \n" +
                "brillo en sus ojos cuando hablaba del cofre y las cosas bellas que pudo ver ahí dentro, además de lo cerca \n " +
                "que estuvo, tomaron la historia de su búsqueda la convirtieron en una lección sobre la perseverancia y \n" +
                "el valor porque al igual que él sueñan con el tesoro y el bosque, sirvienodo de inspiración para seguir sus pasos. \n" +
                "A pesar de no haber logrado encontrar el tesoro, el aventurero continuó con sus aventuras, visitando otros \n" +
                "lugares pero nunca pudo recuperar la misma emoción que sintió en el bosque.");

        }

        #endregion    
    
    }
}
