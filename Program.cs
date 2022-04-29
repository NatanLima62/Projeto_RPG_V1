using System;

namespace Rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            MenuInicial();
        }
        static void MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Bem vindo ao RPG");
            Console.WriteLine("1 - Mago");
            Console.WriteLine("2 - Guerreiro");
            Console.WriteLine("3 - Arqueiro");
            Console.WriteLine("4 - Assassino");
            Console.WriteLine("5 - Sair do jogo");
            Console.Write("Escolha uma das classes de herois acima: ");
            short resultado = short.Parse(Console.ReadLine());

            switch (resultado)
            {
                case 1: Mago(); break;
                case 2: Guerreiro(); break;
                case 3: Arqueiro(); break;
                case 4: Assassino(); break;
                case 5: System.Environment.Exit(0); break;
                default: MenuInicial(); break;
            }
        }
        static void Mago()
        {
            Console.Clear();
            var mago = new ClasseHeroi("Mago", 500, 100, 0, 0, 0, 250);
            Console.Write($"Você esta jogando com a classe: {mago.NomeClasse}\n");
            //Sumonar chefe
            var chefe1 = new Chefe(1, "Aranha Gigante", 1000, 100, 0, 0, 80, 0);
            var chefe2 = new Chefe(2, "Rei Goblin", 1500, 150, 0, 0, 50, 0);
            var chefe3 = new Chefe(3, "Lides dos Assassinos", 800, 50, 0, 0, 100, 0);
            var chefe4 = new Chefe(4, "Demonio", 1000, 80, 0, 0, 80, 0);
            Random numAleatorio = new Random();
            int chefeSumonado = (numAleatorio.Next(1, 4));

            switch (chefeSumonado)
            {
                case 1: Console.Write($"O chefe {chefe1.NomeChefe} apareceu!!\n"); break;
                case 2: Console.Write($"O chefe {chefe2.NomeChefe} apareceu!!\n"); break;
                case 3: Console.Write($"O chefe {chefe3.NomeChefe} apareceu!!\n"); break;
                case 4: Console.Write($"O chefe {chefe4.NomeChefe} apareceu!!\n"); break;
                default: Console.WriteLine("[ERRO!!]"); break;
            }
            switch (chefeSumonado)
            {
                case 1: Console.WriteLine($"[Atributos do chefe: Vida = {chefe1.Vida}, Defesa = {chefe1.Defesa}, PA = {chefe1.PoderDeAtaque}]"); break;
                case 2: Console.WriteLine($"[Atributos do chefe: Vida = {chefe2.Vida}, Defesa = {chefe2.Defesa}, PA = {chefe2.PoderDeAtaque}]"); break;
                case 3: Console.WriteLine($"[Atributos do chefe: Vida = {chefe3.Vida}, Defesa = {chefe3.Defesa}, PA = {chefe3.PoderDeAtaque}]"); break;
                case 4: Console.WriteLine($"[Atributos do chefe: Vida = {chefe4.Vida}, Defesa = {chefe4.Defesa}, PA = {chefe4.PoderDeAtaque}]"); break;
                default: Console.WriteLine("[ERRO!!]"); break;
            }

            void Atacar()
            {
                if (chefeSumonado == chefe1.IdChefe)
                {
                    chefe1.Vida -= mago.PoderDeHabilidade;
                    Console.WriteLine("Você usou um ataque mágico!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe1.Vida}, Defesa = {chefe1.Defesa}, PA = {chefe1.PoderDeAtaque}]");
                    mago.Vida -= chefe1.PoderDeAtaque;
                    Console.WriteLine($"{chefe1.NomeChefe} atacou!!");
                }
                else if(chefeSumonado == chefe2.IdChefe)
                {
                    chefe2.Vida -= mago.PoderDeHabilidade;
                    Console.WriteLine("Você usou um ataque mágico!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe2.Vida}, Defesa = {chefe2.Defesa}, PA = {chefe2.PoderDeAtaque}]");
                    mago.Vida -= chefe1.PoderDeAtaque;
                    Console.WriteLine($"{chefe2.NomeChefe} atacou!!");
                }
                else if(chefeSumonado == chefe3.IdChefe)
                {
                    chefe3.Vida -= mago.PoderDeHabilidade;
                    Console.WriteLine("Você usou um ataque mágico!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe3.Vida}, Defesa = {chefe3.Defesa}, PA = {chefe3.PoderDeAtaque}]");
                    mago.Vida -= chefe1.PoderDeAtaque;
                    Console.WriteLine($"{chefe3.NomeChefe} atacou!!");
                }
                else
                {
                    chefe4.Vida -= mago.PoderDeHabilidade;
                    Console.WriteLine("Você usou um ataque mágico!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe4.Vida}, Defesa = {chefe4.Defesa}, PA = {chefe4.PoderDeAtaque}]");
                    mago.Vida -= chefe1.PoderDeAtaque;
                    Console.WriteLine($"{chefe4.NomeChefe} atacou!!");
                }
            }
            void Defender()
            {
                if (chefeSumonado == chefe1.IdChefe)
                {
                    mago.Vida = (mago.Vida - chefe1.PoderDeAtaque) + 30;
                    Console.WriteLine($"{chefe1.NomeChefe} atacou!!");
                    Console.WriteLine("Você usou usou a defesa!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe1.Vida}, Defesa = {chefe1.Defesa}, PA = {chefe1.PoderDeAtaque}]");
                }
                else if(chefeSumonado == chefe2.IdChefe)
                {
                    mago.Vida = (mago.Vida - chefe2.PoderDeAtaque) + 30;
                    Console.WriteLine($"{chefe2.NomeChefe} atacou!!");
                    Console.WriteLine("Você usou usou a defesa!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe2.Vida}, Defesa = {chefe2.Defesa}, PA = {chefe2.PoderDeAtaque}]");
                }
                else if(chefeSumonado == chefe3.IdChefe)
                {
                    mago.Vida = (mago.Vida - chefe3.PoderDeAtaque) + 30;
                    Console.WriteLine($"{chefe3.NomeChefe} atacou!!");
                    Console.WriteLine("Você usou usou a defesa!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe3.Vida}, Defesa = {chefe3.Defesa}, PA = {chefe3.PoderDeAtaque}]");
                }
                else
                {
                    mago.Vida = (mago.Vida - chefe4.PoderDeAtaque) + 10;
                    Console.WriteLine($"{chefe4.NomeChefe} atacou!!");
                    Console.WriteLine("Você usou usou a defesa!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe4.Vida}, Defesa = {chefe4.Defesa}, PA = {chefe4.PoderDeAtaque}]");
                }
            }
            while (mago.Vida > 0 && chefe1.Vida > 0 && chefe2.Vida > 0 && chefe3.Vida > 0 && chefe4.Vida > 0)
            {
                Console.WriteLine($"[Seus atributos: Vida = {mago.Vida}, Defesa = {mago.Defesa}, PH = {mago.PoderDeHabilidade}]\n");
                Console.WriteLine("1 - Atacar");
                Console.WriteLine("2 - Defender");
                Console.Write("Escolha uma das opções acima: ");
                short acao = short.Parse(Console.ReadLine());
                Console.Clear();
                switch (acao)
                {
                    case 1: Atacar(); break;
                    case 2: Defender(); break;
                    default: ; break;
                }
            }
            if (mago.Vida <= 0)
            {
                Console.WriteLine("Você morreu!!");
            } else if(chefe1.Vida <= 0 || chefe2.Vida <= 0 || chefe3.Vida <= 0 || chefe4.Vida <= 0)
            {
                Console.WriteLine("Parabens você conseguiu derrotar o chefe");
            }
        }
        static void Guerreiro()
        {
            Console.Clear();
            var guerreiro = new ClasseHeroi("Guerreiro", 500, 300, 0, 0, 150, 0);
            Console.Write($"Você esta jogando com a classe: {guerreiro.NomeClasse}\n");
            Console.Write($"[Atributos:Vida = {guerreiro.Vida}, Defesa = {guerreiro.Defesa}, PA = {guerreiro.PoderDeAtaque}]\n");
            //Sumonar chefe
            var chefe1 = new Chefe(1, "Aranha Gigante", 1000, 100, 0, 0, 80, 0);
            var chefe2 = new Chefe(2, "Rei Goblin", 1500, 150, 0, 0, 50, 0);
            var chefe3 = new Chefe(3, "Lides dos Assassinos", 800, 50, 0, 0, 100, 0);
            var chefe4 = new Chefe(4, "Demonio", 1000, 80, 0, 0, 80, 0);
            Random numAleatorio = new Random();
            int chefeSumonado = (numAleatorio.Next(1, 4));

            switch (chefeSumonado)
            {
                case 1: Console.Write($"O chefe {chefe1.NomeChefe} apareceu!!\n"); break;
                case 2: Console.Write($"O chefe {chefe2.NomeChefe} apareceu!!\n"); break;
                case 3: Console.Write($"O chefe {chefe3.NomeChefe} apareceu!!\n"); break;
                case 4: Console.Write($"O chefe {chefe4.NomeChefe} apareceu!!\n"); break;
                default: Console.WriteLine("[ERRO!!]"); break;
            }
            switch (chefeSumonado)
            {
                case 1: Console.WriteLine($"[Atributos do chefe: Vida = {chefe1.Vida}, Defesa = {chefe1.Defesa}, PA = {chefe1.PoderDeAtaque}]"); break;
                case 2: Console.WriteLine($"[Atributos do chefe: Vida = {chefe2.Vida}, Defesa = {chefe2.Defesa}, PA = {chefe2.PoderDeAtaque}]"); break;
                case 3: Console.WriteLine($"[Atributos do chefe: Vida = {chefe3.Vida}, Defesa = {chefe3.Defesa}, PA = {chefe3.PoderDeAtaque}]"); break;
                case 4: Console.WriteLine($"[Atributos do chefe: Vida = {chefe4.Vida}, Defesa = {chefe4.Defesa}, PA = {chefe4.PoderDeAtaque}]"); break;
                default: Console.WriteLine("[ERRO!!]"); break;
            }

            void Atacar()
            {
                if (chefeSumonado == chefe1.IdChefe)
                {
                    chefe1.Vida -= guerreiro.PoderDeAtaque;
                    Console.WriteLine("Você usou um ataque físico!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe1.Vida}, Defesa = {chefe1.Defesa}, PA = {chefe1.PoderDeAtaque}]");
                    guerreiro.Vida -= chefe1.PoderDeAtaque;
                    Console.WriteLine($"{chefe1.NomeChefe} atacou!!");
                }
                else if(chefeSumonado == chefe2.IdChefe)
                {
                    chefe2.Vida -= guerreiro.PoderDeAtaque;
                    Console.WriteLine("Você usou um ataque físico!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe2.Vida}, Defesa = {chefe2.Defesa}, PA = {chefe2.PoderDeAtaque}]");
                    guerreiro.Vida -= chefe2.PoderDeAtaque;
                    Console.WriteLine($"{chefe2.NomeChefe} atacou!!");
                }
                else if(chefeSumonado == chefe3.IdChefe)
                {
                    chefe3.Vida -= guerreiro.PoderDeAtaque;
                    Console.WriteLine("Você usou um ataque físico!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe3.Vida}, Defesa = {chefe3.Defesa}, PA = {chefe3.PoderDeAtaque}]");
                    guerreiro.Vida -= chefe3.PoderDeAtaque;
                    Console.WriteLine($"{chefe3.NomeChefe} atacou!!");
                }
                else
                {
                    chefe3.Vida -= guerreiro.PoderDeAtaque;
                    Console.WriteLine("Você usou um ataque físico!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe4.Vida}, Defesa = {chefe4.Defesa}, PA = {chefe4.PoderDeAtaque}]");
                    guerreiro.Vida -= chefe4.PoderDeAtaque;
                    Console.WriteLine($"{chefe4.NomeChefe} atacou!!");
                }
            }
            void Defender()
            {
                if (chefeSumonado == chefe1.IdChefe)
                {
                    guerreiro.Vida = (guerreiro.Vida - chefe1.PoderDeAtaque) + 30;
                    Console.WriteLine($"{chefe1.NomeChefe} atacou!!");
                    Console.WriteLine("Você usou usou a defesa!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe1.Vida}, Defesa = {chefe1.Defesa}, PA = {chefe1.PoderDeAtaque}]");
                }
                else if(chefeSumonado == chefe2.IdChefe)
                {
                    guerreiro.Vida = (guerreiro.Vida - chefe2.PoderDeAtaque) + 30;
                    Console.WriteLine($"{chefe1.NomeChefe} atacou!!");
                    Console.WriteLine("Você usou usou a defesa!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe2.Vida}, Defesa = {chefe2.Defesa}, PA = {chefe2.PoderDeAtaque}]");
                }
                else if(chefeSumonado == chefe3.IdChefe)
                {
                    guerreiro.Vida = (guerreiro.Vida - chefe3.PoderDeAtaque) + 30;
                    Console.WriteLine($"{chefe3.NomeChefe} atacou!!");
                    Console.WriteLine("Você usou usou a defesa!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe3.Vida}, Defesa = {chefe3.Defesa}, PA = {chefe3.PoderDeAtaque}]");
                }
                else
                {
                    guerreiro.Vida = (guerreiro.Vida - chefe4.PoderDeAtaque) + 30;
                    Console.WriteLine($"{chefe4.NomeChefe} atacou!!");
                    Console.WriteLine("Você usou usou a defesa!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe4.Vida}, Defesa = {chefe4.Defesa}, PA = {chefe4.PoderDeAtaque}]");
                }
            }
            while (guerreiro.Vida > 0 && chefe1.Vida > 0 && chefe2.Vida > 0 && chefe3.Vida > 0 && chefe4.Vida > 0)
            {
                Console.WriteLine($"[Seus atributos: Vida = {guerreiro.Vida}, Defesa = {guerreiro.Defesa}, PA = {guerreiro.PoderDeAtaque}]\n");
                Console.WriteLine("1 - Atacar");
                Console.WriteLine("2 - Defender");
                Console.Write("Escolha uma das opções acima: ");
                short acao = short.Parse(Console.ReadLine());
                Console.Clear();
                switch (acao)
                {
                    case 1: Atacar(); break;
                    case 2: Defender(); break;
                    default: ; break;
                }
            }
            if (guerreiro.Vida <= 0)
            {
                Console.WriteLine("Você morreu!!");
            } else if(chefe1.Vida <= 0 || chefe2.Vida <= 0 || chefe3.Vida <= 0 || chefe4.Vida <= 0)
            {
                Console.WriteLine("Parabens você conseguiu derrotar o chefe");
            }
        }
        static void Arqueiro()
        {
            Console.Clear();
            var arqueiro = new ClasseHeroi("Arqueiro", 400, 120, 0, 0, 250, 0);
            Console.Write($"Você esta jogando com a classe: {arqueiro.NomeClasse}\n");
            Console.Write($"[Atributos:Vida = {arqueiro.Vida}, Defesa = {arqueiro.Defesa}, PA = {arqueiro.PoderDeAtaque}]\n");
            //Sumonar chefe
            var chefe1 = new Chefe(1, "Aranha Gigante", 1000, 100, 0, 0, 80, 0);
            var chefe2 = new Chefe(2, "Rei Goblin", 1500, 150, 0, 0, 50, 0);
            var chefe3 = new Chefe(3, "Lides dos Assassinos", 800, 50, 0, 0, 100, 0);
            var chefe4 = new Chefe(4, "Demonio", 1000, 80, 0, 0, 80, 0);
            Random numAleatorio = new Random();
            int chefeSumonado = (numAleatorio.Next(1, 4));

            switch (chefeSumonado)
            {
                case 1: Console.Write($"O chefe {chefe1.NomeChefe} apareceu!!\n"); break;
                case 2: Console.Write($"O chefe {chefe2.NomeChefe} apareceu!!\n"); break;
                case 3: Console.Write($"O chefe {chefe3.NomeChefe} apareceu!!\n"); break;
                case 4: Console.Write($"O chefe {chefe4.NomeChefe} apareceu!!\n"); break;
                default: Console.WriteLine("[ERRO!!]"); break;
            }
            switch (chefeSumonado)
            {
                case 1: Console.WriteLine($"[Atributos do chefe: Vida = {chefe1.Vida}, Defesa = {chefe1.Defesa}, PA = {chefe1.PoderDeAtaque}]"); break;
                case 2: Console.WriteLine($"[Atributos do chefe: Vida = {chefe2.Vida}, Defesa = {chefe2.Defesa}, PA = {chefe2.PoderDeAtaque}]"); break;
                case 3: Console.WriteLine($"[Atributos do chefe: Vida = {chefe3.Vida}, Defesa = {chefe3.Defesa}, PA = {chefe3.PoderDeAtaque}]"); break;
                case 4: Console.WriteLine($"[Atributos do chefe: Vida = {chefe4.Vida}, Defesa = {chefe4.Defesa}, PA = {chefe4.PoderDeAtaque}]"); break;
                default: Console.WriteLine("[ERRO!!]"); break;
            }

            void Atacar()
            {
                if (chefeSumonado == chefe1.IdChefe)
                {
                    chefe1.Vida -= arqueiro.PoderDeAtaque;
                    Console.WriteLine("Você usou um ataque físico!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe1.Vida}, Defesa = {chefe1.Defesa}, PA = {chefe1.PoderDeAtaque}]");
                    arqueiro.Vida -= chefe1.PoderDeAtaque;
                    Console.WriteLine($"{chefe1.NomeChefe} atacou!!");
                }
                else if(chefeSumonado == chefe2.IdChefe)
                {
                    chefe2.Vida -= arqueiro.PoderDeAtaque;
                    Console.WriteLine("Você usou um ataque físico!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe2.Vida}, Defesa = {chefe2.Defesa}, PA = {chefe2.PoderDeAtaque}]");
                    arqueiro.Vida -= chefe2.PoderDeAtaque;
                    Console.WriteLine($"{chefe2.NomeChefe} atacou!!");
                }
                else if(chefeSumonado == chefe3.IdChefe)
                {
                    chefe3.Vida -= arqueiro.PoderDeAtaque;
                    Console.WriteLine("Você usou um ataque físico!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe3.Vida}, Defesa = {chefe3.Defesa}, PA = {chefe3.PoderDeAtaque}]");
                    arqueiro.Vida -= chefe3.PoderDeAtaque;
                    Console.WriteLine($"{chefe3.NomeChefe} atacou!!");
                }
                else
                {
                    chefe3.Vida -= arqueiro.PoderDeAtaque;
                    Console.WriteLine("Você usou um ataque físico!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe4.Vida}, Defesa = {chefe4.Defesa}, PA = {chefe4.PoderDeAtaque}]");
                    arqueiro.Vida -= chefe4.PoderDeAtaque;
                    Console.WriteLine($"{chefe4.NomeChefe} atacou!!");
                }
            }
            void Defender()
            {
                if (chefeSumonado == chefe1.IdChefe)
                {
                    arqueiro.Vida = (arqueiro.Vida - chefe1.PoderDeAtaque) + 30;
                    Console.WriteLine($"{chefe1.NomeChefe} atacou!!");
                    Console.WriteLine("Você usou usou a defesa!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe1.Vida}, Defesa = {chefe1.Defesa}, PA = {chefe1.PoderDeAtaque}]");
                }
                else if(chefeSumonado == chefe2.IdChefe)
                {
                    arqueiro.Vida = (arqueiro.Vida - chefe2.PoderDeAtaque) + 30;
                    Console.WriteLine($"{chefe1.NomeChefe} atacou!!");
                    Console.WriteLine("Você usou usou a defesa!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe2.Vida}, Defesa = {chefe2.Defesa}, PA = {chefe2.PoderDeAtaque}]");
                }
                else if(chefeSumonado == chefe3.IdChefe)
                {
                    arqueiro.Vida = (arqueiro.Vida - chefe3.PoderDeAtaque) + 30;
                    Console.WriteLine($"{chefe3.NomeChefe} atacou!!");
                    Console.WriteLine("Você usou usou a defesa!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe3.Vida}, Defesa = {chefe3.Defesa}, PA = {chefe3.PoderDeAtaque}]");
                }
                else
                {
                    arqueiro.Vida = (arqueiro.Vida - chefe4.PoderDeAtaque) + 30;
                    Console.WriteLine($"{chefe4.NomeChefe} atacou!!");
                    Console.WriteLine("Você usou usou a defesa!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe4.Vida}, Defesa = {chefe4.Defesa}, PA = {chefe4.PoderDeAtaque}]");
                }
            }
            while (arqueiro.Vida > 0 && chefe1.Vida > 0 && chefe2.Vida > 0 && chefe3.Vida > 0 && chefe4.Vida > 0)
            {
                Console.WriteLine($"[Seus atributos: Vida = {arqueiro.Vida}, Defesa = {arqueiro.Defesa}, PA = {arqueiro.PoderDeAtaque}]\n");
                Console.WriteLine("1 - Atacar");
                Console.WriteLine("2 - Defender");
                Console.Write("Escolha uma das opções acima: ");
                short acao = short.Parse(Console.ReadLine());
                Console.Clear();
                switch (acao)
                {
                    case 1: Atacar(); break;
                    case 2: Defender(); break;
                    default: ; break;
                }
            }
            if (arqueiro.Vida <= 0)
            {
                Console.WriteLine("Você morreu!!");
            } else if(chefe1.Vida <= 0 || chefe2.Vida <= 0 || chefe3.Vida <= 0 || chefe4.Vida <= 0)
            {
                Console.WriteLine("Parabens você conseguiu derrotar o chefe");
            }
        }
        static void Assassino()
        {
            Console.Clear();
            var assassino = new ClasseHeroi("Assassino", 350, 100, 0, 0, 300, 0);
            Console.Write($"Você esta jogando com a classe: {assassino.NomeClasse}\n");
            Console.Write($"[Atributos:Vida = {assassino.Vida}, Defesa = {assassino.Defesa}, PA = {assassino.PoderDeAtaque}]\n");
            //Sumonar chefe
            var chefe1 = new Chefe(1, "Aranha Gigante", 1000, 100, 0, 0, 80, 0);
            var chefe2 = new Chefe(2, "Rei Goblin", 1500, 150, 0, 0, 50, 0);
            var chefe3 = new Chefe(3, "Lides dos Assassinos", 800, 50, 0, 0, 100, 0);
            var chefe4 = new Chefe(4, "Demonio", 1000, 80, 0, 0, 80, 0);
            Random numAleatorio = new Random();
            int chefeSumonado = (numAleatorio.Next(1, 4));

            switch (chefeSumonado)
            {
                case 1: Console.Write($"O chefe {chefe1.NomeChefe} apareceu!!\n"); break;
                case 2: Console.Write($"O chefe {chefe2.NomeChefe} apareceu!!\n"); break;
                case 3: Console.Write($"O chefe {chefe3.NomeChefe} apareceu!!\n"); break;
                case 4: Console.Write($"O chefe {chefe4.NomeChefe} apareceu!!\n"); break;
                default: Console.WriteLine("[ERRO!!]"); break;
            }
            switch (chefeSumonado)
            {
                case 1: Console.WriteLine($"[Atributos do chefe: Vida = {chefe1.Vida}, Defesa = {chefe1.Defesa}, PA = {chefe1.PoderDeAtaque}]"); break;
                case 2: Console.WriteLine($"[Atributos do chefe: Vida = {chefe2.Vida}, Defesa = {chefe2.Defesa}, PA = {chefe2.PoderDeAtaque}]"); break;
                case 3: Console.WriteLine($"[Atributos do chefe: Vida = {chefe3.Vida}, Defesa = {chefe3.Defesa}, PA = {chefe3.PoderDeAtaque}]"); break;
                case 4: Console.WriteLine($"[Atributos do chefe: Vida = {chefe4.Vida}, Defesa = {chefe4.Defesa}, PA = {chefe4.PoderDeAtaque}]"); break;
                default: Console.WriteLine("[ERRO!!]"); break;
            }

            void Atacar()
            {
                if (chefeSumonado == chefe1.IdChefe)
                {
                    chefe1.Vida -= assassino.PoderDeAtaque;
                    Console.WriteLine("Você usou um ataque físico!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe1.Vida}, Defesa = {chefe1.Defesa}, PA = {chefe1.PoderDeAtaque}]");
                    assassino.Vida -= chefe1.PoderDeAtaque;
                    Console.WriteLine($"{chefe1.NomeChefe} atacou!!");
                }
                else if(chefeSumonado == chefe2.IdChefe)
                {
                    chefe2.Vida -= assassino.PoderDeAtaque;
                    Console.WriteLine("Você usou um ataque físico!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe2.Vida}, Defesa = {chefe2.Defesa}, PA = {chefe2.PoderDeAtaque}]");
                    assassino.Vida -= chefe2.PoderDeAtaque;
                    Console.WriteLine($"{chefe2.NomeChefe} atacou!!");
                }
                else if(chefeSumonado == chefe3.IdChefe)
                {
                    chefe3.Vida -= assassino.PoderDeAtaque;
                    Console.WriteLine("Você usou um ataque físico!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe3.Vida}, Defesa = {chefe3.Defesa}, PA = {chefe3.PoderDeAtaque}]");
                    assassino.Vida -= chefe3.PoderDeAtaque;
                    Console.WriteLine($"{chefe3.NomeChefe} atacou!!");
                }
                else
                {
                    chefe3.Vida -= assassino.PoderDeAtaque;
                    Console.WriteLine("Você usou um ataque físico!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe4.Vida}, Defesa = {chefe4.Defesa}, PA = {chefe4.PoderDeAtaque}]");
                    assassino.Vida -= chefe4.PoderDeAtaque;
                    Console.WriteLine($"{chefe4.NomeChefe} atacou!!");
                }
            }
            void Defender()
            {
                if (chefeSumonado == chefe1.IdChefe)
                {
                    assassino.Vida = (assassino.Vida - chefe1.PoderDeAtaque) + 30;
                    Console.WriteLine($"{chefe1.NomeChefe} atacou!!");
                    Console.WriteLine("Você usou usou a defesa!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe1.Vida}, Defesa = {chefe1.Defesa}, PA = {chefe1.PoderDeAtaque}]");
                }
                else if(chefeSumonado == chefe2.IdChefe)
                {
                    assassino.Vida = (assassino.Vida - chefe2.PoderDeAtaque) + 30;
                    Console.WriteLine($"{chefe1.NomeChefe} atacou!!");
                    Console.WriteLine("Você usou usou a defesa!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe2.Vida}, Defesa = {chefe2.Defesa}, PA = {chefe2.PoderDeAtaque}]");
                }
                else if(chefeSumonado == chefe3.IdChefe)
                {
                    assassino.Vida = (assassino.Vida - chefe3.PoderDeAtaque) + 30;
                    Console.WriteLine($"{chefe3.NomeChefe} atacou!!");
                    Console.WriteLine("Você usou usou a defesa!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe3.Vida}, Defesa = {chefe3.Defesa}, PA = {chefe3.PoderDeAtaque}]");
                }
                else
                {
                    assassino.Vida = (assassino.Vida - chefe4.PoderDeAtaque) + 30;
                    Console.WriteLine($"{chefe4.NomeChefe} atacou!!");
                    Console.WriteLine("Você usou usou a defesa!!");
                    Console.WriteLine($"[Atributos do chefe: Vida = {chefe4.Vida}, Defesa = {chefe4.Defesa}, PA = {chefe4.PoderDeAtaque}]");
                }
            }
            while (assassino.Vida > 0 && chefe1.Vida > 0 && chefe2.Vida > 0 && chefe3.Vida > 0 && chefe4.Vida > 0)
            {
                Console.WriteLine($"[Seus atributos: Vida = {assassino.Vida}, Defesa = {assassino.Defesa}, PA = {assassino.PoderDeAtaque}]\n");
                Console.WriteLine("1 - Atacar");
                Console.WriteLine("2 - Defender");
                Console.Write("Escolha uma das opções acima: ");
                short acao = short.Parse(Console.ReadLine());
                Console.Clear();
                switch (acao)
                {
                    case 1: Atacar(); break;
                    case 2: Defender(); break;
                    default: ; break;
                }
            }
            if (assassino.Vida <= 0)
            {
                Console.WriteLine("Você morreu!!");
            } else if(chefe1.Vida <= 0 || chefe2.Vida <= 0 || chefe3.Vida <= 0 || chefe4.Vida <= 0)
            {
                Console.WriteLine("Parabens você conseguiu derrotar o chefe");
            }
        }
    }
    struct ClasseHeroi
    {
        public string NomeClasse;
        public int PoderDeAtaque;
        public int PoderDeHabilidade;
        public int Vida;
        public int Defesa;
        public int PoderEspecial;
        public int Mana;
        public ClasseHeroi(string nomeClasse, int vida, int defesa, int poderEspecial, int mana, int poderDeAtaque = 0, int poderDeHabilidade = 0)
        {
            NomeClasse = nomeClasse;
            PoderDeAtaque = poderDeAtaque;
            PoderDeHabilidade = poderDeHabilidade;
            Vida = vida;
            Defesa = defesa;
            PoderEspecial = poderEspecial;
            Mana = mana;
        }
    }
    struct Chefe
    {
        public int IdChefe;
        public string NomeChefe;
        public int PoderDeAtaque;
        public int PoderDeHabilidade;
        public int Vida;
        public int Defesa;
        public int PoderEspecial;
        public int Mana;
        public Chefe(int idChefe, string nomeChefe, int vida, int defesa, int poderEspecial, int mana, int poderDeAtaque = 0, int poderDeHabilidade = 0)
        {
            IdChefe = idChefe;
            NomeChefe = nomeChefe;
            PoderDeAtaque = poderDeAtaque;
            PoderDeHabilidade = poderDeHabilidade;
            Vida = vida;
            Defesa = defesa;
            PoderEspecial = poderEspecial;
            Mana = mana;
        }
    }
}
