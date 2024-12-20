﻿namespace Subnautica.Events.EventArgs
{
    using System;

    public class ItemDrawedEventArgs : EventArgs
    {
        /**
         *
         * Sınıf ayarlamalarını yapar
         *
         * @author Ismail <ismaiil_0234@hotmail.com>
         *
         */
        public ItemDrawedEventArgs(TechType techType, bool isFirstUseAnimationStarted)
        {
            this.TechType = techType;
            this.IsFirstUseAnimationStarted = isFirstUseAnimationStarted;
        }

        /**
         *
         * TechType Değeri
         *
         * @author Ismail <ismaiil_0234@hotmail.com>
         *
         */
        public TechType TechType { get; private set; }

        /**
         *
         * IsFirstUseAnimationStarted Değeri
         *
         * @author Ismail <ismaiil_0234@hotmail.com>
         *
         */
        public bool IsFirstUseAnimationStarted { get; private set; }
    }
}
