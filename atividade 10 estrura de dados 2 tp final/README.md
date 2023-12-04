# PROJETO LOCAÇÃO – FINAL

Uma empresa de locação de equipamentos atende vários clientes de segmentos diversos. No rol de produtos ofertados existem vários tipos de equipamentos, como computadores, impressoras, datashows entre outros. Cada tipo de equipamento tem uma identificação e um valor de locação diária específico.

O estoque dos produtos da empresa é composto por diversos itens de cada tipo de equipamento. Cada item tem a identificação de patrimônio e uma indicação se está avariado, não podendo ser locado em caso positivo.

Os contratos de locação são solicitados pelo cliente, e neles são registrados sua identificação através de um número sequencial, o agendamento das datas de saída e de retorno dos produtos e a relação dos equipamentos (tipos) necessários, com as respectivas quantidades.

Quando é feita a liberação dos itens de um contrato pelo responsável pelo estoque da empresa (retirada efetiva dos equipamentos pelo cliente), a relação dos itens disponibilizados é armazenada numa sequência do tipo pilha, de forma a garantir, na hora da devolução dos itens contratados, a indicação de uma eventual avaria na mesma sequência que saíram do estoque. Após a devolução de todos os itens, o valor devido referente à locação deve ser informado e o contrato é removido dos controles da empresa.

Para garantir uma maior rotatividade no uso dos equipamentos, existe uma alternância na hora da disponibilização do item, de forma que, quando um item que foi destinado a um determinado contrato retorna à empresa, ele é colocando em último na lista de disponibilidade, garantindo assim o uso equânime dos demais itens do mesmo tipo.

### Opções no seletor:

| Codigo | Opção                                                                 |
| ------ | --------------------------------------------------------------------- |
| 1      | Cadastrar tipo de equipamento                                         |
| 2      | Consultar tipo de equipamento (com os respectivos itens cadastrados)  |
| 3      | Cadastrar equipamento (item em um determinado tipo)                   |
| 4      | Registrar Contrato de Locação                                         |
| 5      | Consultar Contratos de Locação (com os respectivos itens contratados) |
| 6      | Liberar de Contrato de Locação                                        |
| 7      | Consultar Contratos de Locação liberados (com os respectivos itens)   |
| 8      | Devolver equipamentos de Contrato de Locação liberado                 |
