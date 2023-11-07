using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Medications medications = new Medications();
            int option = 0;

            do
            {
                Console.WriteLine("---------------------------------------------------------------------------------------------");
                Console.WriteLine("-----------------------------------------| MENU |--------------------------------------------");
                Console.WriteLine("0. FECHAR");
                Console.WriteLine("1. registrar medicação");
                Console.WriteLine("2. Consultar medicamento (sintético: informar dados1)");
                Console.WriteLine("3. Consultar medicamento (analítico: informar dados1 + lotes2)");
                Console.WriteLine("4. comprar medicação (registrar lote)");
                Console.WriteLine("5. vender medicação (tirar do lote mais antigo)");
                Console.WriteLine("6. lista de medicação (informando dados sintéticos)");
                Console.WriteLine("---------------------------------------------------------------------------------------------");

                Console.Write("Opção: ");

                option = int.Parse(Console.ReadLine());
                Console.WriteLine();
                switch (option)
                {
                    case 0:
                        Console.WriteLine("finalizando processo...");
                        break;
                    case 1:
                        Console.WriteLine("Registrar medicamento");
                        Console.Write("ID: ");
                        int id = int.Parse(Console.ReadLine());
                        Medication medicationToCreate = medications.Search(new Medication(id, "", ""));
                        if (medicationToCreate.Identifier != -1)
                        {
                            Console.WriteLine("Oops...ID ja esta registrado!");
                            break;
                        }
                        Console.Write("Nome: ");
                        string name = Console.ReadLine();
                        Console.Write("Laboratorio: ");
                        string laboratory = Console.ReadLine();
                        medications.Add(new Medication(id, name, laboratory));
                        Console.WriteLine("Medicamento registrado com sucesso!");
                        break;
                    case 2:
                        Console.WriteLine("Consulta de medicamento (data)");
                        Console.Write("ID: ");
                        id = int.Parse(Console.ReadLine());
                        Medication medication = medications.Search(new Medication(id, "", ""));
                        if (medication.Identifier != -1)
                        {
                            Console.WriteLine("\n\n");
                            Console.WriteLine("ID: " + medication.Identifier);
                            Console.WriteLine("Nome: " + medication.Name);
                            Console.WriteLine("Laboratorio: " + medication.Laboratory);
                            Console.WriteLine("quantidade avaliada " + medication.AvailableQuantity());
                        }
                        else
                        {
                            Console.WriteLine("Medicamento nao encontrado");
                        }
                        break;
                    case 3:
                        Console.WriteLine("consulta de medicamento (data + lote)");
                        Console.Write("ID: ");
                        id = int.Parse(Console.ReadLine());
                        medication = medications.Search(new Medication(id, "", ""));
                        if (medication.Identifier != -1)
                        {
                            Console.WriteLine("\n\n");
                            Console.WriteLine("ID: " + medication.Identifier);
                            Console.WriteLine("Nome: " + medication.Name);
                            Console.WriteLine("laboratorio " + medication.Laboratory);
                            Console.WriteLine("quantidade avaliada " + medication.AvailableQuantity());
                            if (medication.Batches.Count > 0)
                            {
                                Console.WriteLine("lotes:");
                                foreach (Batch batch in medication.Batches)
                                {
                                    Console.WriteLine("ID: " + batch.Identifier);
                                    Console.WriteLine("quantidade" + batch.Quantity);
                                    Console.WriteLine("data de validade " + batch.ExpirationDateString);
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Oops...Medication not found!");
                        }
                        break;
                    case 4:
                        Console.WriteLine("compra de medicamentos (registro lote)");
                        Console.Write("medicamento ID: ");
                        id = int.Parse(Console.ReadLine());
                        medication = medications.Search(new Medication(id, "", ""));
                        if (medication.Identifier != -1)
                        {
                            Console.Write("Lote ID: ");
                            int batchId = int.Parse(Console.ReadLine());
                            Batch batchToSearch = medications.SearchBatch(medication, new Batch(batchId, 0, DateTime.Now));
                            if (batchToSearch.Identifier != -1)
                            {
                                Console.WriteLine("ID lote ja esta cadastrado");
                                break;
                            }
                            Console.Write("quantidade: ");
                            int quantity = int.Parse(Console.ReadLine());
                            Console.Write("Data de validade...");
                            Console.Write("Dia: ");
                            int day = int.Parse(Console.ReadLine());
                            Console.Write("Mes: ");
                            int month = int.Parse(Console.ReadLine());
                            Console.Write("ano: ");
                            int year = int.Parse(Console.ReadLine());
                            DateTime expirationDate = new DateTime(year, month, day);
                            Batch batch = new Batch(batchId, quantity, expirationDate);
                            medication.Purchase(batch);
                            Console.WriteLine("lote registrado com sucesso!");
                        }
                        else
                        {
                            Console.WriteLine("Oops...medicamento nao encontrado!");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Sell medication (deduct from the oldest batch)");
                        Console.Write("ID: ");
                        id = int.Parse(Console.ReadLine());
                        medication = medications.Search(new Medication(id, "", ""));
                        if (medication.Identifier != -1)
                        {
                            Console.Write("quantidade: ");
                            int quantity = int.Parse(Console.ReadLine());
                            if (medication.Sell(quantity))
                            {
                                Console.WriteLine("venda completada com sucesso!");
                            }
                            else
                            {
                                Console.WriteLine("Oops...a venda nao foi completada com sucesso");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Medicamento nao encontrado");
                        }
                        break;
                    case 6:
                        Console.WriteLine("lista de medicamentos");
                        Console.WriteLine("Medicamentos: \n\n");
                        foreach (Medication m in medications.MedicationList)
                        {
                            Console.WriteLine("ID: " + m.Identifier);
                            Console.WriteLine("Name: " + m.Name);
                            Console.WriteLine("Laboratorio: " + m.Laboratory);
                            Console.WriteLine("Quantidade avaliada: " + m.AvailableQuantity());
                        }
                        break;
                }
            } while (option != 0);
        }
    }
}

