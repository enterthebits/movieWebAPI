# MovieWebAPI

Após rodar, acessar em {API}/Movies

Esta API fornece dados sobre os próximos filmes que serão lançados.

Foi utilizado a biblioteca externa NewtonSoft para serialização e deserialização dos dados no formato JSON

A API to TMDb fornece apenas dados de 20 filmes por requisição. Para tanto, afim de não haver tal limitação, a controller realiza uma paginação na API do TMDb, e acumula os dados dos filmes, até que todos os dados estejam disponíveis em nossa API, para, enfim, disponibilizá-los.

Para que se tenha maior clareza do gênero, as IDs recebidas são convertidas nos textos equivalentes, da requisição de gêneros na TMDb.

A camada de conexão não foi criada individualmente, de modo que a utilização de rede está implementada junto como modelo.

A resposta da API é um JSON puro, ao invés de uma response com os códigos de http status.

Havendo oportunidade de mais tempo para refatoração, proponho-me a completar o desafio com solução mais adequada.

Agradeço a oportunidade de avaliação.
