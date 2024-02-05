# Gerenciamento-de-pacientes-hospitalares
Sistema de recepção de pacientes à hospitais em C#

Sistema para controle de pacientes em ambientes hospitalares. Basicamente o sistema armazena dados de pacientes em um arquivo e também lê esses dados.
O sistema cria uma fila(estruturas auto-referenciadas) aonde os pacientes são adicionados à ela de acordo com a ordem de chegada, além disso, o sistema cria objetos Paciente(orientado a objetos) para facilitar os processos do sistema.

Para registrar um paciente, o sistema escreve os dados do paciente no arquivo, caso o paciente ja esteja registrado, o programa lê o arquivo e pelo ID( informado no registro) consgue adicionar o paciente à fila.

-Código é comentado-
