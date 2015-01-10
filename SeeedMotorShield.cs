using System;
using Microsoft.SPOT;
using Microsoft.SPOT.Hardware;
using SecretLabs.NETMF.Hardware.Netduino;
using System.Threading;

namespace SmallYellow
{
    public class SeeedMotorShield
    {
        public OutputPort MotorShieldLftPos;
        public OutputPort MotorShieldLftNeg;
        public OutputPort MotorShieldRhtPos;
        public OutputPort MotorShieldRhtNeg;
        public PWM SpeedPinA;
        public PWM SpeedPinB;

        public static SeeedMotorShield Init()
        {
            return new SeeedMotorShield
            {
                MotorShieldLftPos = new OutputPort(Pins.GPIO_PIN_D8, false),
                MotorShieldLftNeg = new OutputPort(Pins.GPIO_PIN_D11, false),
                MotorShieldRhtPos = new OutputPort(Pins.GPIO_PIN_D12, false),
                MotorShieldRhtNeg = new OutputPort(Pins.GPIO_PIN_D13, false),
                SpeedPinA = new PWM(PWMChannels.PWM_PIN_D9, 100, 0, false),
                SpeedPinB = new PWM(PWMChannels.PWM_PIN_D10, 100, 0, false)
            };
        }

        public SeeedMotorShield Continue(int milliseconds)
        {
            Thread.Sleep(milliseconds);
            return this;
        }

        public SeeedMotorShield SetSpeed(double speed)
        {
            SpeedPinA.DutyCycle = speed;
            SpeedPinB.DutyCycle = speed;
            return this;
        }

        public SeeedMotorShield Stop()
        {
            SpeedPinA.Stop();
            SpeedPinB.Stop();
            return this;
        }

        public SeeedMotorShield Start()
        {
            SpeedPinA.Start();
            SpeedPinB.Start();
            return this;
        }

        public SeeedMotorShield GoBackward()
        {
            MotorShieldLftPos.Write(true);
            MotorShieldLftNeg.Write(false);
            MotorShieldRhtPos.Write(true);
            MotorShieldRhtNeg.Write(false);
            return this;
        }

        public SeeedMotorShield GoForward()
        {
            MotorShieldLftPos.Write(false);
            MotorShieldLftNeg.Write(true);
            MotorShieldRhtPos.Write(false);
            MotorShieldRhtNeg.Write(true);
            return this;
        }

        public SeeedMotorShield TurnRight()
        {
            MotorShieldLftPos.Write(true);
            MotorShieldLftNeg.Write(false);
            MotorShieldRhtPos.Write(false);
            MotorShieldRhtNeg.Write(true);
            return this;
        }

        public SeeedMotorShield TurnLeft()
        {
            MotorShieldLftPos.Write(false);
            MotorShieldLftNeg.Write(true);
            MotorShieldRhtPos.Write(true);
            MotorShieldRhtNeg.Write(false);
            return this;
        }
    }
}
