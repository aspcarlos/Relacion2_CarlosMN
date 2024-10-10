namespace Relacion2_CarlosMN;

public class Ejercicio04 : ContentPage
{
	public Ejercicio04()
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

        Grid grid = new Grid
        {
            Padding = new Thickness(40),
            RowDefinitions =
            {
                new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Auto) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) },
                new RowDefinition { Height = new GridLength(1, GridUnitType.Star) }
            },
            ColumnDefinitions =
            {
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) },
                new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) }
            }
        };

        #region TITULO Y ENTRY
        // Agregar el Label
        Label label = new Label
        {
            FontAttributes = FontAttributes.Bold,
            FontSize = 20,
            HorizontalTextAlignment = TextAlignment.Center,
            Text = "R2: Ejercicio 4",
            TextColor = Color.FromArgb("#CCCCCC"),
            Margin = new Thickness(0, 10, 0, 10)
        };
        Grid.SetRow(label, 0);
        Grid.SetColumnSpan(label, 4);
        grid.Children.Add(label);

        // Agregar el Entry
        Entry EntradaCalculadora = new Entry
        {
            BackgroundColor = Color.FromArgb("#2A2A2A"),
            Keyboard = Keyboard.Text,
            Placeholder = "",
            PlaceholderColor = Color.FromArgb("#7d7c7c"),
            Margin = new Thickness(0, 10, 0, 10),
            TextColor = Color.FromArgb("#CCCCCC")
        };
        Grid.SetRow(EntradaCalculadora, 1);
        Grid.SetColumnSpan(EntradaCalculadora, 4);
        grid.Children.Add(EntradaCalculadora);

        #endregion

        #region BOTONES

        Button boton7 = new Button
        {
            Text = "7",
            FontSize = 20,
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#FFFFFF"),
            Command = new Command(Button_Clicked_7),
            Margin = new Thickness(0, 10, 0, 10)
        };

        Button boton8 = new Button
        {
            Text = "8",
            FontSize = 20,
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#FFFFFF"),
            Margin = new Thickness(0, 10, 0, 10),
            Command = new Command(Button_Clicked_8)
        };

        Button boton9 = new Button
        {
            Text = "9",
            FontSize = 20,
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#FFFFFF"),
            Margin = new Thickness(0, 10, 0, 10),
            Command = new Command(Button_Clicked_9)
        };

        Button buttonMultiplicar = new Button
        {
            Text = "*",
            FontSize = 20,
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#FFFFFF"),
            Margin = new Thickness(0, 10, 0, 10),
            Command = new Command(Button_Clicked_Multiplicar)
        };

        Button boton4 = new Button
        {
            Text = "4",
            FontSize = 20,
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#FFFFFF"),
            Margin = new Thickness(0, 10, 0, 10),
            Command = new Command(Button_Clicked_4)
        };

        Button boton5 = new Button
        {
            Text = "5",
            FontSize = 20,
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#FFFFFF"),
            Margin = new Thickness(0, 10, 0, 10),
            Command = new Command(Button_Clicked_5)
        };

        Button boton6 = new Button
        {
            Text = "6",
            FontSize = 20,
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#FFFFFF"),
            Margin = new Thickness(0, 10, 0, 10),
            Command = new Command(Button_Clicked_6)
        };

        Button botonSumar = new Button
        {
            Text = "+",
            FontSize = 20,
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#FFFFFF"),
            Margin = new Thickness(0, 10, 0, 10),
            Command = new Command(Button_Clicked_Sumar)
        };

        Button boton1 = new Button
        {
            Text = "1",
            FontSize = 20,
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#FFFFFF"),
            Margin = new Thickness(0, 10, 0, 10),
            Command = new Command(Button_Clicked_1)
        };

        Button boton2 = new Button
        {
            Text = "2",
            FontSize = 20,
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#FFFFFF"),
            Margin = new Thickness(0, 10, 0, 10),
            Command = new Command(Button_Clicked_2)
        };

        Button boton3 = new Button
        {
            Text = "3",
            FontSize = 20,
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#FFFFFF"),
            Margin = new Thickness(0, 10, 0, 10),
            Command = new Command(Button_Clicked_3)
        };

        Button botonDividir = new Button
        {
            Text = "÷",
            FontSize = 20,
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#FFFFFF"),
            Margin = new Thickness(0, 10, 0, 10),
            Command = new Command(Button_Clicked_Dividir)
        };

        Button boton0 = new Button
        {
            Text = "0",
            FontSize = 20,
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#FFFFFF"),
            Margin = new Thickness(0, 10, 0, 10),
            Command = new Command(Button_Clicked_0)
        };

        Button botonPorcentaje = new Button
        {
            Text = "%",
            FontSize = 20,
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#FFFFFF"),
            Margin = new Thickness(0, 10, 0, 10),
            Command = new Command(Button_Clicked_Porcentaje)
        };

        Button botonRestar = new Button
        {
            Text = "-",
            FontSize = 20,
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#FFFFFF"),
            Margin = new Thickness(0, 10, 0, 10),
            Command = new Command(Button_Clicked_Restar)
        };

        Button botonIgual = new Button
        {
            Text = "=",
            FontSize = 20,
            BackgroundColor = Color.FromArgb("#7d7c7c"),
            TextColor = Color.FromArgb("#FFFFFF"),
            Margin = new Thickness(0, 10, 0, 10),
            Command = new Command(Button_Clicked_Igual)
        };

        #endregion

        #region Añadir botones al Grid
        Grid.SetRow(boton7, 2); Grid.SetColumn(boton7, 0);
        grid.Children.Add(boton7);

        Grid.SetRow(boton8, 2); Grid.SetColumn(boton8, 1);
        grid.Children.Add(boton8);

        Grid.SetRow(boton9, 2); Grid.SetColumn(boton9, 2);
        grid.Children.Add(boton9);

        Grid.SetRow(buttonMultiplicar, 2); Grid.SetColumn(buttonMultiplicar, 3);
        grid.Children.Add(buttonMultiplicar);

        Grid.SetRow(boton4, 3); Grid.SetColumn(boton4, 0);
        grid.Children.Add(boton4);

        Grid.SetRow(boton5, 3); Grid.SetColumn(boton5, 1);
        grid.Children.Add(boton5);

        Grid.SetRow(boton6, 3); Grid.SetColumn(boton6, 2);
        grid.Children.Add(boton6);

        Grid.SetRow(botonSumar, 3); Grid.SetColumn(botonSumar, 3);
        grid.Children.Add(botonSumar);

        Grid.SetRow(boton1, 4); Grid.SetColumn(boton1, 0);
        grid.Children.Add(boton1);

        Grid.SetRow(boton2, 4); Grid.SetColumn(boton2, 1);
        grid.Children.Add(boton2);

        Grid.SetRow(boton3, 4); Grid.SetColumn(boton3, 2);
        grid.Children.Add(boton3);

        Grid.SetRow(botonDividir, 4); Grid.SetColumn(botonDividir, 3);
        grid.Children.Add(botonDividir);

        Grid.SetRow(boton0, 5); Grid.SetColumn(boton0, 0);
        grid.Children.Add(boton0);

        Grid.SetRow(botonPorcentaje, 5); Grid.SetColumn(botonPorcentaje, 1);
        grid.Children.Add(botonPorcentaje);

        Grid.SetRow(botonRestar, 5); Grid.SetColumn(botonRestar, 2);
        grid.Children.Add(botonRestar);

        Grid.SetRow(botonIgual, 5); Grid.SetColumn(botonIgual, 3);
        grid.Children.Add(botonIgual);
        #endregion

        // Finalmente, asignar el layout a la página
        this.Content = grid;

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