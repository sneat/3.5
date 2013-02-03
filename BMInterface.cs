using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BMDSwitcherAPI;

namespace BMDGLC
{
    public partial class BMInterface : Form
    {
        private IBMDSwitcherDiscovery SwitcherDiscovery;
        private IBMDSwitcher Switcher;
        private IBMDSwitcherMixEffectBlock MixEffectBlock1;
        private IBMDSwitcherInput Input;
        private IBMDSwitcherInputAux AUX, AUX1, AUX2, AUX3;
        private IBMDSwitcherInputColor Color, Color1, Color2;
        private IBMDSwitcherKey Me1_Key1, Me1_Key2, Me1_Key3, Me1_Key4;


        private bool MoveSliderDownwards = false;
        private bool CurrentTransitionReachedHalfway = false;
        int inTransition;

        private AudioMixerMonitorOutputMonitor AudioMixerMonitorOutputMonitor;
        private AudioMixerMonitor AudioMixerMonitor;
        private AudioInputMonitor AudioInputMonitor;
        private SwitcherMonitor SwitcherMonitor;
        private InputMonitor InputMonitor;
        private MixEffectBlockMonitor MixEffectBlockMonitor;
        private SwitcherClipMonitor SwitcherClipMonitor;
        private DownStreamKeyMonitor DownStreamKeyMonitor;
        private InputAuxMonitor AuxMonitor;
        private InputColorMonitor InputColorMonitor;
        private InputSuperSourceMonitor InputSuperSourceMonitor;
        private KeyMonitor KeyMonitor;
        private ChromaKeyMonitor ChromaKeyMonitor;
        private DVEKeyMonitor DVEKeyMonitor;
        private FlyKeyMonitor FlyKeyMonitor;
        private LumaKeyMonitor LumaKeyMonitor;
        private PatternKeyMonitor PatternKeyMonitor;
        private LockMonitor LockMonitor;
        private MediaPlayerMonitor MediaPlayerMonitor;
        private MediaPoolMonitor MediaPoolMonitor;
        private MultiviewMonitor MultiviewMonitor;
        private StillsMonitor StillsMonitor;
        private TransitionMonitor TransitionMonitor;
        private DipTransitionMonitor DipTransitionMonitor;
        private DVETransitionMonitor DVETransitionMonitor;
        private MixTransitionMonitor MixTransitionMonitor;
        private StingerTransitionMonitor StingerTransitionMonitor;
        private WipeTransitionMonitor WipeTransitionMonitor;

        public BMInterface()
        {
            InitializeComponent();

            AudioMixerMonitorOutputMonitor = new AudioMixerMonitorOutputMonitor();
            AudioMixerMonitor = new AudioMixerMonitor();
            AudioInputMonitor = new AudioInputMonitor();
            SwitcherMonitor = new SwitcherMonitor();
            InputMonitor = new InputMonitor(Input);
            MixEffectBlockMonitor = new MixEffectBlockMonitor();
            SwitcherClipMonitor = new SwitcherClipMonitor();
            DownStreamKeyMonitor = new DownStreamKeyMonitor();
            AuxMonitor = new InputAuxMonitor();
            InputColorMonitor = new InputColorMonitor();
            InputSuperSourceMonitor = new InputSuperSourceMonitor();
            KeyMonitor = new KeyMonitor();
            ChromaKeyMonitor = new ChromaKeyMonitor();
            DVEKeyMonitor = new DVEKeyMonitor();
            FlyKeyMonitor = new FlyKeyMonitor();
            LumaKeyMonitor = new LumaKeyMonitor();
            PatternKeyMonitor = new PatternKeyMonitor();
            LockMonitor = new LockMonitor();
            MediaPlayerMonitor = new MediaPlayerMonitor();
            MediaPoolMonitor = new MediaPoolMonitor();
            MultiviewMonitor = new MultiviewMonitor();
            StillsMonitor = new StillsMonitor();
            TransitionMonitor = new TransitionMonitor();
            DipTransitionMonitor = new DipTransitionMonitor();
            DVETransitionMonitor = new DVETransitionMonitor();
            MixTransitionMonitor = new MixTransitionMonitor();
            StingerTransitionMonitor = new StingerTransitionMonitor();
            WipeTransitionMonitor = new WipeTransitionMonitor();

            SwitcherDiscovery = new CBMDSwitcherDiscovery();
            if (SwitcherDiscovery == null)
            {
                MessageBox.Show("Could not create Switcher Discovery Instance.\nATEM Switcher Software may not be installed.", "Error");
                Environment.Exit(1);
            }

            AudioMixerMonitorOutputMonitor.DimChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => AudioOutputDimChanged())));
            AudioMixerMonitorOutputMonitor.DimLevelChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => AudioOutputDimLevelChanged())));
            AudioMixerMonitorOutputMonitor.GainChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => AudioOutputGainChanged())));
            AudioMixerMonitorOutputMonitor.LevelNotificationChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => AudioOutputLevelNotificationChanged())));
            AudioMixerMonitorOutputMonitor.MonitorEnableChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => AudioOutputEnableChanged())));
            AudioMixerMonitorOutputMonitor.MuteChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => AudioOutputMuteChanged())));
            AudioMixerMonitorOutputMonitor.SoloChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => AudioOutputSoloChanged())));
            AudioMixerMonitorOutputMonitor.SoloInputChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => AudioOutputSoloInputChanged())));

            AudioMixerMonitor.ProgramOutBalanceChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => AudioProgramOutBalanceChanged())));
            AudioMixerMonitor.ProgramOutGainChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => AudioProgramOutGainChanged())));
            AudioMixerMonitor.ProgramOutLevelNotificationChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => AudioProgramOutLevelNotificationChanged())));

            AudioInputMonitor.BalanceChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => AudioBalanceChanged())));
            AudioInputMonitor.GainChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => AudioGainChanged())));
            AudioInputMonitor.IsMixedInChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => AudioIsMixedInChanged())));
            AudioInputMonitor.LevelNotificationChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => AudioLevelNotificationChanged())));
            AudioInputMonitor.MixOptionChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => AudioMixOptionChanged())));

            SwitcherMonitor.SwitcherDisconnected += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => SwitcherDisconnected())));
            SwitcherMonitor.DownConvertModeChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DownConvertModeChanged())));
            SwitcherMonitor.ProductNameChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => ProductNameChanged())));
            SwitcherMonitor.VideoModeChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => VideoModeChanged())));

            SwitcherDisconnected();		// start with switcher disconnected
        }

        private void DownConvertModeChanged()
        {
        }

        private void ProductNameChanged()
        {
        }

        private void VideoModeChanged()
        {
        }

        private void AudioOutputDimChanged()
        { 
        }

        private void AudioOutputDimLevelChanged()
        {
        }

        private void AudioOutputGainChanged()
        {
        }

        private void AudioOutputMuteChanged()
        {
        }

        private void AudioOutputSoloChanged()
        {
        }

        private void AudioOutputSoloInputChanged()
        {
        }

        private void AudioOutputLevelNotificationChanged()
        {
        }

        private void AudioOutputEnableChanged()
        {
        }

        private void AudioProgramOutBalanceChanged()
        {
        }

        private void AudioProgramOutGainChanged()
        {
        }

        private void AudioProgramOutLevelNotificationChanged()
        {
        }

        private void AudioBalanceChanged()
        {
        }

        private void AudioGainChanged()
        {
        }

        private void AudioIsMixedInChanged()
        {
        }

        private void AudioLevelNotificationChanged()
        {
        }

        private void AudioMixOptionChanged()
        {
        }

        private void SwitcherConnected()
        {
            
            // Get the switcher name:
            string SwitcherName;
            Switcher.GetString(_BMDSwitcherPropertyId.bmdSwitcherPropertyIdProductName, out SwitcherName);
            
            // Install SwitcherMonitor callbacks:
            Switcher.AddCallback(SwitcherMonitor);

            // We create input monitors for each input. To do this we iterator over all inputs:
            // This will allow us to update the combo boxes when input names change:
            long PortType;
            int AUXCount = 0;
            int ColorCount = 0;
            IBMDSwitcherInputIterator InputIterator;
            if (SwitcherAPIHelper.CreateIterator(Switcher, out InputIterator))
            {
                InputIterator.Next(out Input);
                while (Input != null)
                {
                    Input.GetInt(BMDSwitcherAPI._BMDSwitcherInputPropertyId.bmdSwitcherInputPropertyIdPortType, out PortType);

                    if ((_BMDSwitcherPortType)PortType == BMDSwitcherAPI._BMDSwitcherPortType.bmdSwitcherPortTypeAuxOutput)
                    {
                        AUXCount += 1;

                        AUX = (IBMDSwitcherInputAux)Input;

                        if (AUXCount == 1)
                        {
                            AUX1 = AUX;
                        }

                        if (AUXCount == 2)
                        {
                            AUX2 = AUX;
                        }

                        if (AUXCount == 3)
                        {
                            AUX3 = AUX;
                        }
                    }

                    if ((_BMDSwitcherPortType)PortType == BMDSwitcherAPI._BMDSwitcherPortType.bmdSwitcherPortTypeColorGenerator)
                    {
                        ColorCount += 1;

                        Color = (IBMDSwitcherInputColor)Input;

                        if (ColorCount == 1)
                        {
                            Color1 = Color;
                        }

                        if (ColorCount == 2)
                        {
                            Color2 = Color;
                        }
                    }

                    Input.AddCallback(InputMonitor);
                    InputIterator.Next(out Input);
                }
            }

            // We want to get the first Mix Effect block (ME 1). We create a ME iterator,
            // and then get the first one:
            MixEffectBlock1 = null;
            IBMDSwitcherMixEffectBlockIterator MeIterator;
            SwitcherAPIHelper.CreateIterator(Switcher, out MeIterator);

            if (MeIterator != null)
            {
                MeIterator.Next(out MixEffectBlock1);
            }

            if (MixEffectBlock1 == null)
            {
                MessageBox.Show("Unexpected: Could not get first mix effect block", "Error");
                return;
            }

            IBMDSwitcherKeyIterator KeyIterator;
            SwitcherAPIHelper.CreateIterator(MixEffectBlock1, out KeyIterator);

            if (KeyIterator != null)
            {
                KeyIterator.Next(out Me1_Key1);
                KeyIterator.Next(out Me1_Key2);
                KeyIterator.Next(out Me1_Key3);
                KeyIterator.Next(out Me1_Key4);
            }

            if (Me1_Key1 == null || Me1_Key2 == null || Me1_Key3 == null || Me1_Key4 == null)
            {
                MessageBox.Show("Unexpected: Could not get one of the Keyers.", "Error");
                return;
            }

            // Install MixEffectBlockMonitor callbacks:
            MixEffectBlock1.AddCallback(MixEffectBlockMonitor);
        }

        private void SwitcherDisconnected()
        {
            // Remove all input monitors, remove callbacks
            
            if (MixEffectBlock1 != null)
            {
                // Remove callback
                MixEffectBlock1.RemoveCallback(MixEffectBlockMonitor);

                // Release reference
                MixEffectBlock1 = null;
            }

            if (Switcher != null)
            {
                // Remove callback:
                Switcher.RemoveCallback(SwitcherMonitor);

                // release reference:
                Switcher = null;
            }
        }

        private void UpdateSliderPosition()
        {
            double transitionPos;

            MixEffectBlock1.GetFloat(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdTransitionPosition, out transitionPos);

            CurrentTransitionReachedHalfway = (transitionPos >= 0.50);

            if (MoveSliderDownwards)
                trackBarTransitionPos.Value = 100 - (int)(transitionPos * 100);
            else
                trackBarTransitionPos.Value = (int)(transitionPos * 100);
        }

        private void OnInTransitionChanged()
        {
            MixEffectBlock1.GetFlag(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdInTransition, out inTransition);

            if (inTransition == 0)
            {
                // Toggle the starting orientation of slider handle if a transition has passed through halfway
                if (CurrentTransitionReachedHalfway)
                {
                    MoveSliderDownwards = !MoveSliderDownwards;
                    UpdateSliderPosition();
                }
                CurrentTransitionReachedHalfway = false;
            }
        }

        private void trackBarTransitionPos_Scroll(object sender, EventArgs e)
        {
            if (MixEffectBlock1 != null)
            {
                double position = trackBarTransitionPos.Value / 100.0;
                if (MoveSliderDownwards)
                    position = (100 - trackBarTransitionPos.Value) / 100.0;

                MixEffectBlock1.SetFloat(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdTransitionPosition,
                    position);
            }
        }

        private void btn_key1layer_Click(object sender, EventArgs e)
        {

        }
    }
}
