# MovieWebAPI

Esta API fornece dados sobre os próximos filmes que serão lançados.

Foi utilizado a biblioteca externa NewtonSoft para serialização e deserialização dos dados no formato JSON

A API to TMDb fornece apenas dados de 20 filmes por requisição. Para tanto, afim de não haver tal limitação, a controller realiza uma paginação na API do TMDb, e acumula os dados dos filmes, até que todos os dados estejam disponíveis em nossa API, para, enfim, disponibilizá-los.

Para que se tenha maior clareza do gênero, as IDs recebidas são convertidas nos textos equivalentes, da requisição de gêneros na TMDb.

Agradeço a oportunidade de avaliação.
