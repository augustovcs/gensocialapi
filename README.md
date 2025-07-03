# 🧠 GenAPI – Universal AI Image Generation API

**GenAPI** é uma API robusta e multiplataforma desenvolvida com **ASP.NET Razor Pages**, criada para conectar modelos de geração de imagem (como Replicate, Stable Diffusion, DALL·E, entre outros) a qualquer sistema externo — seja um aplicativo mobile, frontend web ou serviço de backend.

A GenAPI permite enviar prompts de texto via requisições HTTP e receber imagens geradas por inteligência artificial. Toda a lógica de consumo das IAs está encapsulada na API, oferecendo uma interface limpa, segura e extensível. A API também permite armazenar e consultar o histórico de prompts e imagens geradas, além de oferecer endpoints prontos para integração com UI/UX modernos.

---

## 🚀 Features

- 🔗 **Integração universal com IA de geração de imagens** (Replicate, DALL·E, etc.)
- 🧩 Desenvolvida com **ASP.NET Razor Pages**
- ⚡ Endpoints REST para envio de prompts e retorno de imagens
- 🖼️ Retorno em tempo real de imagens geradas por IA
- 📂 Armazenamento local ou em nuvem das imagens geradas
- 🧠 Suporte a múltiplos modelos e parâmetros customizáveis
- 🧾 Histórico de prompts e resultados por usuário
- 🔐 Suporte para autenticação básica via token ou header
- 📃 Interface Swagger (OpenAPI) para testes e documentação
- 📸 Possibilidade de exportar imagens geradas em base64 ou URL direta
- 🧪 Estrutura preparada para testes automatizados

---

## 💡 Exemplo de Fluxo: Geração de Imagem

### 🔄 POST `/api/image/generate`

| Parâmetro   | Tipo    | Descrição                                |
|-------------|---------|--------------------------------------------|
| `prompt`    | string  | Descrição textual para geração da imagem  |
| `model`     | string  | (Opcional) Nome do modelo de IA a ser usado |
| `userId`    | string  | (Opcional) Identificador do usuário        |

#### ✅ Resposta (Exemplo)
```json
{
  "imageUrl": "https://cdn.genapi.com/images/xyz123.png",
  "prompt": "A futuristic city floating in the sky",
  "model": "stable-diffusion-v1.5",
  "createdAt": "2025-07-03T11:35:00Z"
}
