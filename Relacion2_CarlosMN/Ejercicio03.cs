namespace Relacion2_CarlosMN;

public class Ejercicio03 : ContentPage
{
	public Ejercicio03()
	{
        #region LISTA PARA GUARDAR LOS NUMEROS Y VARIABLES PARA LAS OPERACIONES MATEMATICAS
        List<int> numeros = new List<int>();  // Lista para almacenar todos los números ingresados

        // Inicializacion de las operaciones de la Calculadora
        bool multiplicando = false;
        bool sumando = false;
        bool dividiendo = false;
        bool restando = false;
        bool porcentaje = false;
        #endregion

        VerticalStackLayout verticalStack = new VerticalStackLayout
        {
            // Thickness: Sirve para definir el grosor de los márgenes, rellenos o bordes en controles dentro de una interfaz de usuario
            Padding = new Thickness(40),
            Spacing = 10
        };

        #region TITULO Y ENTRY
        // Agregar el Label
        Label label = new Label
        {
            FontAttributes = FontAttributes.Bold,
            FontSize = 20,
            HorizontalTextAlignment = TextAlignment.Center,
            Text = "R2: Ejercicio 3",
            TextColor = Color.FromArgb("#CCCCCC")
        };

        // Agregar el Entry
        Entry EntradaCalculadora = new Entry
        {
            BackgroundColor = Color.FromArgb("#2A2A2A"),
            Keyboard = Keyboard.Text,
            Placeholder = "",
            PlaceholderColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#CCCCCC")
        };
        #endregion

        #region HorizontalStackLayout para los botones 7, 8, 9 y multiplicar
        HorizontalStackLayout fila1 = new HorizontalStackLayout
        {
            Spacing = 10
        };

        Button boton7 = new Button
        {
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            FontSize = 20,
            Text = "7",
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_7)
        };

        Button boton8 = new Button
        {
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            FontSize = 20,
            Text = "8",
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_8)
        };

        Button boton9 = new Button
        {
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            FontSize = 20,
            Text = "9",
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_9)
        };

        Button buttonMultiplicar = new Button
        {
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            FontSize = 20,
            Text = "*",
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_Multiplicar)
        };

        fila1.Children.Add(boton7);
        fila1.Children.Add(boton8);
        fila1.Children.Add(boton9);
        fila1.Children.Add(buttonMultiplicar);
        #endregion

        #region HorizontalStackLayout para los botones 4, 5, 6 y sumar
        HorizontalStackLayout fila2 = new HorizontalStackLayout
        {
            Spacing = 10
        };

        Button boton4 = new Button
        {
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            FontSize = 20,
            Text = "4",
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_4)
        };

        Button boton5 = new Button
        {
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            FontSize = 20,
            Text = "5",
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_5)
        };

        Button boton6 = new Button
        {
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            FontSize = 20,
            Text = "6",
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_6)
        };

        Button botonSumar = new Button
        {
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            FontSize = 20,
            Text = "+",
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_Sumar)
        };

        fila2.Children.Add(boton4);
        fila2.Children.Add(boton5);
        fila2.Children.Add(boton6);
        fila2.Children.Add(botonSumar);
        #endregion

        #region HorizontalStackLayout para los botones 1, 2, 3 y dividir
        HorizontalStackLayout fila3 = new HorizontalStackLayout
        {
            Spacing = 10
        };

        Button boton1 = new Button
        {
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            FontSize = 20,
            Text = "1",
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_1)
        };

        Button boton2 = new Button
        {
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            FontSize = 20,
            Text = "2",
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_2)
        };

        Button boton3 = new Button
        {
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            FontSize = 20,
            Text = "3",
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_3)
        };

        Button botonDividir = new Button
        {
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            FontSize = 20,
            Text = "÷",
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_Dividir)
        };

        fila3.Children.Add(boton1);
        fila3.Children.Add(boton2);
        fila3.Children.Add(boton3);
        fila3.Children.Add(botonDividir);
        #endregion

        #region HorizontalStackLayout para los botones 0, porcentaje, restar e igual
        HorizontalStackLayout fila4 = new HorizontalStackLayout
        {
            Spacing = 10
        };

        Button boton0 = new Button
        {
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            FontSize = 20,
            Text = "0",
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_0)
        };

        Button botonPorcentaje = new Button
        {
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            FontSize = 20,
            Text = "%",
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_Porcentaje)
        };

        Button botonRestar = new Button
        {
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            FontSize = 20,
            Text = "-",
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_Restar)
        };

        Button botonIgual = new Button
        {
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            FontSize = 20,
            Text = "=",
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_Igual)
        };

        fila4.Children.Add(boton0);
        fila4.Children.Add(botonPorcentaje);
        fila4.Children.Add(botonRestar);
        fila4.Children.Add(botonIgual);
        #endregion

        // Añadir todos los controles al VerticalStackLayout
        verticalStack.Children.Add(label);
        verticalStack.Children.Add(EntradaCalculadora);
        verticalStack.Children.Add(fila1);
        verticalStack.Children.Add(fila2);
        verticalStack.Children.Add(fila3);
        verticalStack.Children.Add(fila4);

        // Finalmente, asignar el layout a la página
        this.Content = verticalStack;

        #region BOTONES NUMEROS
        /// <summary>
        /// Añadimos funcionalidad a los botones asignados a los numeros
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Button_Clicked_0(object obj)
        {
            EntradaCalculadora.Text += "0";  // Agrega "7" al texto actual
        }

        void Button_Clicked_1(object obj)
        {
            EntradaCalculadora.Text += "1";  // Agrega "1" al texto actual
        }

        void Button_Clicked_2(object obj)
        {
            EntradaCalculadora.Text += "2";  // Agrega "2" al texto actual
        }

        void Button_Clicked_3(object obj)
        {
            EntradaCalculadora.Text += "3";  // Agrega "3" al texto actual
        }

        void Button_Clicked_4(object obj)
        {
            EntradaCalculadora.Text += "4";  // Agrega "4" al texto actual
        }

        void Button_Clicked_5(object obj)
        {
            EntradaCalculadora.Text += "5";  // Agrega "5" al texto actual
        }

        void Button_Clicked_6(object obj)
        {
            EntradaCalculadora.Text += "6";  // Agrega "6" al texto actual
        }

        void Button_Clicked_7(object obj)
        {
            EntradaCalculadora.Text += "7";  // Agrega "7" al texto actual
        }

        void Button_Clicked_8(object obj)
        {
            EntradaCalculadora.Text += "8";  // Agrega "8" al texto actual
        }

        void Button_Clicked_9(object obj)
        {
            EntradaCalculadora.Text += "9";  // Agrega "9" al texto actual
        }
        #endregion

        #region BOTONES OPERACIONES MATEMATICAS
        /// <summary>
        /// Botones asignados a hacer el tipo de operaciones que usuario desee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Button_Clicked_Multiplicar(object obj)
        {
            if (string.IsNullOrWhiteSpace(EntradaCalculadora.Text))
            {
                DisplayAlert("Error", "Por favor, ingresa un número antes de realizar la operación.", "OK");
                return;
            }

            if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int numero))
            {
                // Añadir el número a la lista
                numeros.Add(numero);

                // Mostrar la operación con el símbolo de multiplicación
                EntradaCalculadora.Text += " * ";

                multiplicando = true;
            }
            else
            {
                DisplayAlert("Error", "El valor ingresado no es un número válido.", "OK");
            }
        }
        void Button_Clicked_Dividir(object obj)
        {
            if (string.IsNullOrWhiteSpace(EntradaCalculadora.Text))
            {
                DisplayAlert("Error", "Por favor, ingresa un número antes de realizar la operación.", "OK");
                return;
            }

            if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int numero))
            {
                // Añadir el número a la lista
                numeros.Add(numero);

                // Mostrar la operación con el símbolo de division
                EntradaCalculadora.Text += " ÷ ";

                dividiendo = true;
            }
            else
            {
                DisplayAlert("Error", "El valor ingresado no es un número válido.", "OK");
            }
        }

        void Button_Clicked_Sumar(object obj)
        {
            if (string.IsNullOrWhiteSpace(EntradaCalculadora.Text))
            {
                DisplayAlert("Error", "Por favor, ingresa un número antes de realizar la operación.", "OK");
                return;
            }

            if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int numero))
            {
                // Añadir el número a la lista
                numeros.Add(numero);

                // Mostrar la operación con el símbolo de la suma
                EntradaCalculadora.Text += " + ";

                sumando = true;
            }
            else
            {
                DisplayAlert("Error", "El valor ingresado no es un número válido.", "OK");
            }
        }

        void Button_Clicked_Restar(object obj)
        {
            if (string.IsNullOrWhiteSpace(EntradaCalculadora.Text))
            {
                DisplayAlert("Error", "Por favor, ingresa un número antes de realizar la operación.", "OK");
                return;
            }

            if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int numero))
            {
                // Añadir el número a la lista
                numeros.Add(numero);

                // Mostrar la operación con el símbolo de la resta
                EntradaCalculadora.Text += " - ";

                restando = true;
            }
            else
            {
                DisplayAlert("Error", "El valor ingresado no es un número válido.", "OK");
            }
        }

        void Button_Clicked_Porcentaje(object obj)
        {
            if (string.IsNullOrWhiteSpace(EntradaCalculadora.Text))
            {
                DisplayAlert("Error", "Por favor, ingresa un número antes de realizar la operación.", "OK");
                return;
            }

            if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int numero))
            {
                // Añadir el número a la lista
                numeros.Add(numero);

                // Mostrar la operación con el símbolo del porcentaje
                EntradaCalculadora.Text += " % ";

                porcentaje = true;
            }
            else
            {
                DisplayAlert("Error", "El valor ingresado no es un número válido.", "OK");
            }
        }
        #endregion

        #region BOTON QUE MOSTRARA EL RESULTADO EN EL ENTRY
        /// <summary>
        /// Boton que limpiara el Entry y mostrara el resultado de la operacion
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void Button_Clicked_Igual(object obj)
        {
            if (sumando)
            {
                // Añadir el último número después del símbolo "+"
                if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int ultimoNumero))
                {
                    numeros.Add(ultimoNumero);  // Añadir el último número a la lista

                    // Realizar la suma acumulada
                    int resultado = 0;  // Empezamos con 0 porque vamos a sumar

                    foreach (int num in numeros)
                    {
                        resultado += num;
                    }

                    // Borrar el Entry y mostrar el resultado
                    EntradaCalculadora.Text = resultado.ToString();

                    // Reiniciar la lista de números y el estado
                    numeros.Clear();
                    sumando = false;
                }
            }

            if (restando)
            {
                // Añadir el último número después del símbolo "-"
                if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int ultimoNumero))
                {
                    numeros.Add(ultimoNumero);  // Añadir el último número a la lista

                    // Inicializar el resultado con el primer número de la lista
                    int resultado = numeros[0];

                    // Realizar la resta acumulada a partir del segundo número
                    for (int i = 1; i < numeros.Count; i++)
                    {
                        resultado -= numeros[i];
                    }

                    // Borrar el Entry y mostrar el resultado
                    EntradaCalculadora.Text = resultado.ToString();

                    // Reiniciar la lista de números y el estado
                    numeros.Clear();
                    restando = false;
                }
            }

            if (multiplicando)
            {
                // Añadir el último número después del símbolo "*"
                if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int ultimoNumero))
                {
                    numeros.Add(ultimoNumero);  // Añadir el último número a la lista

                    // Realizar la multiplicación acumulada
                    int resultado = 1;  // Empezamos con 1 porque vamos a multiplicar

                    foreach (int num in numeros)
                    {
                        resultado *= num;
                    }

                    // Borrar el Entry y mostrar el resultado
                    EntradaCalculadora.Text = resultado.ToString();

                    // Reiniciar la lista de números y el estado
                    numeros.Clear();
                    multiplicando = false;
                }
            }

            if (dividiendo)
            {
                // Añadir el último número después del símbolo "÷"
                if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int ultimoNumero))
                {
                    numeros.Add(ultimoNumero);  // Añadir el último número a la lista

                    // Inicializar el resultado con el primer número de la lista
                    int resultado = numeros[0];

                    // Realizar la división acumulada a partir del segundo número
                    for (int i = 1; i < numeros.Count; i++)
                    {
                        if (numeros[i] == 0)
                        {
                            // Mostrar un mensaje de error si se intenta dividir por cero
                            EntradaCalculadora.Text = "Error: División por 0";
                            numeros.Clear();
                            dividiendo = false;
                            return;  // Salir de la operación
                        }

                        resultado /= numeros[i];
                    }

                    // Borrar el Entry y mostrar el resultado
                    EntradaCalculadora.Text = resultado.ToString();

                    // Reiniciar la lista de números y el estado
                    numeros.Clear();
                    dividiendo = false;
                }
            }

            if (porcentaje)
            {
                if (int.TryParse(EntradaCalculadora.Text.Split(' ').Last(), out int ultimoNumero))
                {
                    // Añadir el último número a la lista
                    numeros.Add(ultimoNumero);

                    // Si hay más de un número, calculamos el porcentaje
                    if (numeros.Count > 1)
                    {
                        // El primer número es la base para el porcentaje
                        int baseNumero = numeros[0];
                        int porcentajeNumero = numeros[1]; // El segundo número es el porcentaje a calcular
                                                           // Calcular el porcentaje
                        double resultado = (baseNumero * porcentajeNumero) / 100.0; // Realizar el cálculo
                        EntradaCalculadora.Text = resultado.ToString();
                    }
                    else
                    {
                        // Si solo hay un número, simplemente muestra su valor en porcentaje
                        EntradaCalculadora.Text = (ultimoNumero / 100.0).ToString();
                    }
                    numeros.Clear();
                    porcentaje = false; // Reiniciar el estado
                }
            }
        }
        #endregion
    }
}