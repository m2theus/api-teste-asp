# Configuração do MYSQL


## Steps to setup

**1. Criar e executar o Mysql localmente na porta 3306**

**2. Criar o banco de dados**
```bash
create database dbtestebackend
configurar usuário e senha de acesso do mysql para root
```

**3. Executar migartions**
```bash
Para executar o migration do projeto e criar a tabela de pessoas deve-se acessar a pasta Api.Data e executar o comando:
 dotnet ef database update 
```
