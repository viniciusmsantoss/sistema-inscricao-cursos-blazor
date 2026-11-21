# SistemaInscricaoCursosBlazor — Formulário Interativo em Blazor

Aplicação Web desenvolvida em **Blazor Web App** para gestão de inscrições em cursos, aplicando validações com `DataAnnotations`, vinculação de formulários e processamento assíncrono.

---

## 📌 Informações do Aluno

- **Nome:** Vinícius Miranda
- **RA:** 124114120
- **Curso:** Engenharia de Software (UniBH)
- **Disciplina:** Usabilidade, Desenvolvimento Web, Mobile e Jogos (UDWMJ)
- **Professor:** Daniel Henrique Matos de Paiva

---

## 🚀 Funcionalidades

- **Validação de Dados (`DataAnnotations`):** Regras obrigatórias (`[Required]`), validação de formato de e-mail (`[EmailAddress]`) e faixa etária de 16 a 100 anos (`[Range(16, 100)]`).
- **Componentes Blazor:** Uso de `<EditForm>`, `<DataAnnotationsValidator/>`, `<ValidationSummary/>`, `<ValidationMessage>` e `<InputSelect>`.
- **Feedback Assíncrono:** Simulação de envio de dados com `Task.Delay(2000)`, bloqueando o botão e alterando o estado visual para *"Processando..."* durante a operação.

---

## 🛠️ Tecnologias Utilizadas

- **C# / .NET**
- **Blazor Web App (`InteractiveServer`)**
- **System.ComponentModel.DataAnnotations**
- **Bootstrap 5**
