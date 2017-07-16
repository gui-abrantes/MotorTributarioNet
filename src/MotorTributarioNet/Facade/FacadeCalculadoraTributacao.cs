﻿using MotorTributarioNet.Flags;
using MotorTributarioNet.Impostos;
using MotorTributarioNet.Impostos.Csosns.Componentes;

namespace MotorTributarioNet.Facade
{
    public class FacadeCalculadoraTributacao
    {
        private readonly ITributavel _tributavel;
        private readonly TipoDesconto _tipoDesconto;

        public FacadeCalculadoraTributacao(ITributavel tributavel, TipoDesconto tipoDesconto)
        {
            _tributavel = tributavel;
            _tipoDesconto = tipoDesconto;
        }

        public IResultadoCalculoIcms CalculaIcms()
        {
            return new TributacaoIcms(_tributavel, _tipoDesconto).Calcula();
        }

        public IResultadoCalculoIpi CalculaIpi()
        {
            return new TributacaoIpi(_tributavel, _tipoDesconto).Calcula();
        }
    }
}