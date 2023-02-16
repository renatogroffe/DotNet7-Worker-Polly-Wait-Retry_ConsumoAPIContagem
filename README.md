# DotNet7-Worker-Polly-Wait-Retry_ConsumoAPIContagem
Exemplo de consumo em um Worker Service criado com .NET 7 de uma API REST (contagem de acessos), utilizando para isto a biblioteca Polly e o padrão Retry para tratamento de falhas (incluindo o uso de um tempo de para evitar erros HTTP 429 - Too Many Requests).

API REST que serviu de base para a implementação deste projeto:

**https://github.com/renatogroffe/ASPNETCore7-WebApi-RateLimitingFixedWindow-StatusCode429_ContagemAcessos**