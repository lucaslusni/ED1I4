#include <iostream>
#include <string>
#include <vector>

class Venda {
private:
    int dia;
    double valor;

public:
    Venda(int d, double v) : dia(d), valor(v) {}

    int getDia() const {
        return dia;
    }

    double getValor() const {
        return valor;
    }
};

class Vendedor {
private:
    int id;
    std::string nome;
    double percComissao;
    std::vector<Venda> asVendas;

public:
    Vendedor(int i, const std::string& n, double p)
        : id(i), nome(n), percComissao(p) {}

    void registrarVenda(int dia, const Venda& venda) {
        asVendas.push_back(venda);
    }

    double valorVendas() const {
        double total = 0.0;
        for (const Venda& venda : asVendas) {
            total += venda.getValor();
        }
        return total;
    }

    double valorComissao() const {
        return valorVendas() * percComissao;
    }
};

class Vendedores {
private:
    std::vector<Vendedor> osVendedores;
    int max = 10;

public:
    bool addVendedor(const Vendedor& v) {
        if (osVendedores.size() < max) {
            osVendedores.push_back(v);
            return true;
        }
        return false;
    }

    bool delVendedor(const Vendedor& v) {
        if (v.valorVendas() == 0.0) {
            for (auto it = osVendedores.begin(); it != osVendedores.end(); ++it) {
                if (it->id == v.id) {
                    osVendedores.erase(it);
                    return true;
                }
            }
        }
        return false;
    }

    Vendedor* searchVendedor(const Vendedor& v) {
        for (Vendedor& vend : osVendedores) {
            if (vend.id == v.id) {
                return &vend;
            }
        }
        return nullptr;
    }

    double valorVendas() const {
        double total = 0.0;
        for (const Vendedor& vend : osVendedores) {
            total += vend.valorVendas();
        }
        return total;
    }

    double valorComissao() const {
        double total = 0.0;
        for (const Vendedor& vend : osVendedores) {
            total += vend.valorComissao();
        }
        return total;
    }
};

int main() {
    Vendedores vendedores;

    while (true) {
        int option;
        std::cout << "OPÇÕES:\n"
                  << "0. Sair\n"
                  << "1. Cadastrar vendedor\n"
                  << "2. Consultar vendedor\n"
                  << "3. Excluir vendedor\n"
                  << "4. Registrar venda\n"
                  << "5. Listar vendedores\n"
                  << "Escolha uma opção: ";
        std::cin >> option;

        if (option == 0) {
            break;
        } else if (option == 1) {
            int id;
            std::string nome;
            double percComissao;
            std::cout << "Informe o ID do vendedor: ";
            std::cin >> id;
            std::cout << "Informe o nome do vendedor: ";
            std::cin.ignore(); // To clear newline character
            std::getline(std::cin, nome);
            std::cout << "Informe a percentagem de comissão do vendedor: ";
            std::cin >> percComissao;

            Vendedor novoVendedor(id, nome, percComissao);
            if (vendedores.addVendedor(novoVendedor)) {
                std::cout << "Vendedor cadastrado com sucesso!\n";
            } else {
                std::cout << "Limite máximo de vendedores atingido.\n";
            }
        } else if (option == 2) {
            int id;
            std::cout << "Informe o ID do vendedor: ";
            std::cin >> id;
            Vendedor busca(id, "", 0.0);
            Vendedor* encontrado = vendedores.searchVendedor(busca);
            if (encontrado) {
                std::cout << "ID: " << encontrado->id << "\n";
                std::cout << "Nome: " << encontrado->nome << "\n";
                std::cout << "Valor total das vendas: " << encontrado->valorVendas() << "\n";
                std::cout << "Valor da comissão devida: " << encontrado->valorComissao() << "\n";
                std::cout << "Valor médio das vendas diárias:\n";

                // Cálculo do valor médio das vendas diárias
                for (int dia = 1; dia <= 31; ++dia) {
                    double totalDia = 0.0;
                    int numVendasDia = 0;
                    for (const Venda& venda : encontrado->asVendas) {
                        // Considera apenas as vendas do dia atual
                        if (venda.getDia() == dia) {
                            totalDia += venda.getValor();
                            numVendasDia++;
                        }
                    }
                    if (numVendasDia > 0) {
                        double media = totalDia / numVendasDia;
                        std::cout << "Dia " << dia << ": " << media << "\n";
                    }
                }
            } else {
                std::cout << "Vendedor não encontrado.\n";
            }
        } else if (option == 3) {
            int id;
            std::cout << "Informe o ID do vendedor: ";
            std::cin >> id;
            Vendedor busca(id, "", 0.0);
            Vendedor* encontrado = vendedores.searchVendedor(busca);
            if (encontrado) {
                if (vendedores.delVendedor(*encontrado)) {
                    std::cout << "Vendedor excluído com sucesso!\n";
                } else {
                    std::cout << "Não foi possível excluir o vendedor. Verifique se há vendas associadas.\n";
                }
            } else {
                std::cout << "Vendedor não encontrado.\n";
            }
        } else if (option == 4) {
            int id;
            int dia;
            int qtde;
            double valor;
            std::cout << "Informe o ID do vendedor: ";
            std::cin >> id;
            Vendedor busca(id, "", 0.0);
            Vendedor* encontrado = vendedores.searchVendedor(busca);
            if (encontrado) {
                std::cout << "Informe o dia da venda: ";
                std::cin >> dia;
                std::cout << "Informe a quantidade vendida: ";
                std::cin >> qtde;
                std::cout << "Informe o valor total da venda: ";
                std::cin >> valor;
                Venda novaVenda(dia, valor);
                encontrado->registrarVenda(dia, novaVenda);
                std::cout << "Venda registrada com sucesso!\n";
            } else {
                std::cout << "Vendedor não encontrado.\n";
            }
        } else if (option == 5) {
            for (const Vendedor& v : vendedores.osVendedores) {
                std::cout << "ID: " << v.id << "\n";
                std::cout << "Nome: " << v.nome << "\n";
                std::cout << "Valor total das vendas: " << v.valorVendas() << "\n";
                std::cout << "Valor da comissão devida: " << v.valorComissao() << "\n";
            }
            std::cout << "Total de vendas de todos os vendedores: " << vendedores.valorVendas() << "\n";
            std::cout << "Total de comissão devida de todos os vendedores: " << vendedores.valorComissao() << "\n";
        } else {
            std::cout << "Opção inválida. Tente novamente.\n";
        }
    }

    return 0;
}
