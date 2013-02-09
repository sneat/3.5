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
        private IBMDSwitcherTransitionParameters Transition;
        private IBMDSwitcherDownstreamKey Me1_DKey1, Me1_DKey2;
        private IBMDSwitcherMediaPlayer MediaPlayer1, MediaPlayer2;


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
        private InputAuxMonitor InputAuxMonitor;
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
            InputAuxMonitor = new InputAuxMonitor();
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

            MixEffectBlockMonitor.FadeToBlackFramesRemainingChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => FadeToBlackFramesRemainingChanged())));
            MixEffectBlockMonitor.FadeToBlackRateChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => FadeToBlackRateChanged())));
            MixEffectBlockMonitor.InFadeToBlackChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => InFadeToBlackChanged())));
            MixEffectBlockMonitor.InTransitionChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => InTransitionChanged())));
            MixEffectBlockMonitor.TransitionPositionChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => TransitionPositionChanged())));
            MixEffectBlockMonitor.TransitionFramesRemainingChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => TransitionFramesRemainingChanged())));
            MixEffectBlockMonitor.PreviewTransitionChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => PreviewTransitionChanged())));
            MixEffectBlockMonitor.ProgramInputChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => ProgramInputChanged())));
            MixEffectBlockMonitor.PreviewInputChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => PreviewInputChanged())));
            MixEffectBlockMonitor.PreviewInputChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => PreviewInputChanged())));
           
            InputAuxMonitor.InputSourceChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => InputAuxChanged())));

            KeyMonitor.CanBeDVEKeyChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => KeyerCanBeDVEKeyChanged())));
            KeyMonitor.InputCutChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => KeyerInputCutChanged())));
            KeyMonitor.InputFillChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => KeyerInputFillChanged())));
            KeyMonitor.MaskBottomChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => KeyerMaskBottomChanged())));
            KeyMonitor.MaskedChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => KeyerMaskedChanged())));
            KeyMonitor.MaskLeftChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => KeyerMaskLeftChanged())));
            KeyMonitor.MaskRightChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => KeyerMaskRightChanged())));
            KeyMonitor.MaskTopChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => KeyerMaskTopChanged())));
            KeyMonitor.OnAirChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => KeyerOnAirChanged())));
            KeyMonitor.TypeChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => KeyerTypeChanged())));

            TransitionMonitor.NextTransitionSelectionChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => NextTransitionSelectionChanged())));
            TransitionMonitor.NextTransitionStyleChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => NextTransitionStyleChanged())));
            TransitionMonitor.TransitionSelectionChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => TransitionSelectionChanged())));
            TransitionMonitor.TransitionStyleChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => TransitionStyleChanged())));

            DownStreamKeyMonitor.ClipChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerClipChanged())));
            DownStreamKeyMonitor.FramesRemainingChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerFramesRemainingChanged())));
            DownStreamKeyMonitor.GainChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerGainChanged())));
            DownStreamKeyMonitor.InputCutChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerInputCutChanged())));
            DownStreamKeyMonitor.InputFillChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerInputFillChanged())));
            DownStreamKeyMonitor.InverseChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerInverseChanged())));
            DownStreamKeyMonitor.IsAutoTransitioningChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerIsAutoTransitioningChanged())));
            DownStreamKeyMonitor.IsTransitioningChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerIsTransitioningChanged())));
            DownStreamKeyMonitor.MaskBottomChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerMaskBottomChanged())));
            DownStreamKeyMonitor.MaskedChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerMaskedChanged())));
            DownStreamKeyMonitor.MaskLeftChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerMaskLeftChanged())));
            DownStreamKeyMonitor.MaskRightChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerMaskRightChanged())));
            DownStreamKeyMonitor.MaskTopChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerMaskTopChanged())));
            DownStreamKeyMonitor.OnAirChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerOnAirChanged())));
            DownStreamKeyMonitor.PreMultipliedChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerPreMultipliedChanged())));
            DownStreamKeyMonitor.RateChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerRateChanged())));
            DownStreamKeyMonitor.TieChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => DKeyerTieChanged())));

            MultiviewMonitor.WindowChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => MultiviewWindowChanged())));
            MultiviewMonitor.LayoutChanged += new SwitcherEventHandler((s, a) => this.Invoke((Action)(() => MultiviewLayoutChanged())));

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

        private void FadeToBlackFramesRemainingChanged()
        {
            double FTBFramesRemaining;

            MixEffectBlock1.GetFloat(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdFadeToBlackFramesRemaining, out FTBFramesRemaining);

            tb_FTBRate.Text = FTBFramesRemaining.ToString();
        }

        private void FadeToBlackRateChanged()
        {
            double FTBRate;

            MixEffectBlock1.GetFloat(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdFadeToBlackRate, out FTBRate);

            tb_FTBRate.Text = FTBRate.ToString();
        }

        private void InFadeToBlackChanged()
        {
            double InFTB;

            MixEffectBlock1.GetFloat(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdInFadeToBlack, out InFTB);

            if (InFTB == 1)
            {
                btn_FTB.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
            }
            else
            {
                btn_FTB.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            }
        }

        private void TransitionPositionChanged()
        {
            double transitionPos;

            MixEffectBlock1.GetFloat(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdTransitionPosition, out transitionPos);

            CurrentTransitionReachedHalfway = (transitionPos >= 0.50);

            if (MoveSliderDownwards)
                trackBarTransitionPos.Value = 100 - (int)(transitionPos * 100);
            else
                trackBarTransitionPos.Value = (int)(transitionPos * 100);
        }

        private void TransitionFramesRemainingChanged()
        {
            double FramesRemaining;

            MixEffectBlock1.GetFloat(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdFadeToBlackFramesRemaining, out FramesRemaining);

            tb_TransitionFrames.Text = FramesRemaining.ToString();
        }

        private void InTransitionChanged()
        {
            MixEffectBlock1.GetFlag(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdInTransition, out inTransition);

            if (inTransition == 0)
            {
                // Toggle the starting orientation of slider handle if a transition has passed through halfway
                if (CurrentTransitionReachedHalfway)
                {
                    MoveSliderDownwards = !MoveSliderDownwards;
                    TransitionPositionChanged();
                }
                CurrentTransitionReachedHalfway = false;
            }
        }

        private void PreviewTransitionChanged()
        {
            long PreviewTrans;

            MixEffectBlock1.GetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewTransition, out PreviewTrans);
            if (PreviewTrans == 1)
            {
                btn_prevtrans.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
            }
            else
            {
                btn_prevtrans.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            }
        }

        private void ProgramInputChanged()
        {
            long ProgramInput;

            MixEffectBlock1.GetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput, out ProgramInput);

            btn_blackprog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_hdmi1prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_hdmi2prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_hdmi3prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_hdmi4prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_camera1prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_camera2prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_camera3prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_camera4prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_barsprog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_color1prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_color2prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_media1prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_media2prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));

            switch (ProgramInput)
            {
                case (0):
                    btn_blackprog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (1):
                    btn_hdmi1prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (2):
                    btn_hdmi2prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (3):
                    btn_hdmi3prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (4):
                    btn_hdmi4prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (5):
                    btn_camera1prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (6):
                    btn_camera2prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (7):
                    btn_camera3prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (8):
                    btn_camera4prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (9):
                    btn_barsprog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (10):
                    btn_color1prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (11):
                    btn_color2prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (12):
                    btn_media1prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (13):
                    btn_media2prog.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;
            }
        }

        private void PreviewInputChanged()
        {
            long PreviewInput;

            MixEffectBlock1.GetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput, out PreviewInput);

            btn_blackprew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_hdmi1prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_hdmi2prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_hdmi3prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_hdmi4prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_camera1prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_camera2prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_camera3prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_camera4prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_barsprew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_color1prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_color2prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_media1prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_media2prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));

            switch (PreviewInput)
            {
                case (0):
                    btn_blackprew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (1):
                    btn_hdmi1prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (2):
                    btn_hdmi2prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (3):
                    btn_hdmi3prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (4):
                    btn_hdmi4prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (5):
                    btn_camera1prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (6):
                    btn_camera2prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (7):
                    btn_camera3prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (8):
                    btn_camera4prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (9):
                    btn_barsprew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (10):
                    btn_color1prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (11):
                    btn_color2prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (12):
                    btn_media1prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;

                case (13):
                    btn_media2prew.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
                    break;
            }
        }

        private void InputAuxChanged()
        {
            long Aux1Input;
            long Aux2Input;
            long Aux3Input;

            AUX1.GetInputSource(out Aux1Input);
            AUX2.GetInputSource(out Aux2Input);
            AUX3.GetInputSource(out Aux3Input);

            blackToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            hDMI1ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            hDMI2ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            hDMI3ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            hDMI4ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            camera1ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            camera2ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            camera3ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            camera4ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            colorBarsToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            color1ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            color2ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            mediaPlayer1ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            mediaPlayer1KeyToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            mediaPlayer2ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            mediaPlayer2KeyToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            programToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            previewToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            cleanFeed1ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            cleanFeed2ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));

            blackToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            hDMI1ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            hDMI2ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            hDMI3ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            hDMI4ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            camera1ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            camera2ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            camera3ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            camera4ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            colorBarsToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            color1ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            color2ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            mediaPlayer1ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            mediaPlayer1KeyToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            mediaPlayer2ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            mediaPlayer2KeyToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            programToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            previewToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            cleanFeed1ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            cleanFeed2ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));

            blackToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            hDMI1ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            hDMI2ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            hDMI3ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            hDMI4ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            camera1ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            camera2ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            camera3ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            camera4ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            colorBarsToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            color1ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            color2ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            mediaPlayer1ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            mediaPlayer1KeyToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            mediaPlayer2ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            mediaPlayer2KeyToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            programToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            previewToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            cleanFeed1ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            cleanFeed2ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));

            switch (Aux1Input)
            {
                case (0):
                    blackToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (1):
                    hDMI1ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (2):
                    hDMI2ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (3):
                    hDMI3ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (4):
                    hDMI4ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (5):
                    camera1ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (6):
                    camera2ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (7):
                    camera3ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (8):
                    camera4ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (9):
                    colorBarsToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (10):
                    color1ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (11):
                    color2ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (12):
                    mediaPlayer1ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (13):
                    mediaPlayer1KeyToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;


                case (14):
                    mediaPlayer2ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (15):
                    mediaPlayer2KeyToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (16):
                    programToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (17):
                    previewToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (18):
                    cleanFeed1ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (19):
                    cleanFeed2ToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;
            }

            switch (Aux2Input)
            {
                case (0):
                    blackToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (1):
                    hDMI1ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (2):
                    hDMI2ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (3):
                    hDMI3ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (4):
                    hDMI4ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (5):
                    camera1ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (6):
                    camera2ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (7):
                    camera3ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (8):
                    camera4ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (9):
                    colorBarsToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (10):
                    color1ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (11):
                    color2ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (12):
                    mediaPlayer1ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (13):
                    mediaPlayer1KeyToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;


                case (14):
                    mediaPlayer2ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (15):
                    mediaPlayer2KeyToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (16):
                    programToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (17):
                    previewToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (18):
                    cleanFeed1ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (19):
                    cleanFeed2ToolStripMenuItem1.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;
            }

            switch (Aux3Input)
            {
                case (0):
                    blackToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (1):
                    hDMI1ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (2):
                    hDMI2ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (3):
                    hDMI3ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (4):
                    hDMI4ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (5):
                    camera1ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (6):
                    camera2ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (7):
                    camera3ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (8):
                    camera4ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (9):
                    colorBarsToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (10):
                    color1ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (11):
                    color2ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (12):
                    mediaPlayer1ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (13):
                    mediaPlayer1KeyToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;


                case (14):
                    mediaPlayer2ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (15):
                    mediaPlayer2KeyToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (16):
                    programToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (17):
                    previewToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (18):
                    cleanFeed1ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;

                case (19):
                    cleanFeed2ToolStripMenuItem2.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongreen));
                    break;
            }
        }

        private void KeyerCanBeDVEKeyChanged()
        {
        }

        private void KeyerInputCutChanged()
        {
        }

        private void KeyerInputFillChanged()
        {
        }

        private void KeyerMaskBottomChanged()
        {
        }

        private void KeyerMaskRightChanged()
        {
        }

        private void KeyerMaskedChanged()
        {
        }

        private void KeyerMaskLeftChanged()
        {
        }

        private void KeyerMaskTopChanged()
        {
        }

        private void KeyerOnAirChanged()
        {
            int Keyer1OnAir;
            int Keyer2OnAir;
            int Keyer3OnAir;
            int Keyer4OnAir;

            Me1_Key1.GetOnAir(out Keyer1OnAir);
            Me1_Key2.GetOnAir(out Keyer2OnAir);
            Me1_Key3.GetOnAir(out Keyer3OnAir);
            Me1_Key4.GetOnAir(out Keyer4OnAir);

            if (Keyer1OnAir == 0)
            {
                btn_key1air.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            }
            else
            {
                btn_key1air.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
            }

            if (Keyer2OnAir == 0)
            {
                btn_key2air.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            }
            else
            {
                btn_key2air.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
            }

            if (Keyer3OnAir == 0)
            {
                btn_key3air.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            }
            else
            {
                btn_key3air.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
            }

            if (Keyer4OnAir == 0)
            {
                btn_key4air.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            }
            else
            {
                btn_key4air.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
            }
        }

        private void KeyerTypeChanged()
        {
        }

        private void NextTransitionSelectionChanged()
        {
        }

        private void TransitionSelectionChanged()
        {
        }

        private void NextTransitionStyleChanged()
        {
            _BMDSwitcherTransitionStyle NextTransitionStyle;

            Transition.GetNextTransitionStyle(out NextTransitionStyle);

            
                    btn_dip.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
                    btn_mix.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
                    btn_DVE.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
                    btn_sting.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
                    btn_wipe.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));

            switch (NextTransitionStyle)
            {
                case (_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleDip):
                    btn_dip.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
                    break;

                case (_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleDVE):
                    btn_DVE.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
                    break;

                case (_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleMix):
                    btn_mix.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
                    break;

                case (_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleStinger):
                    btn_sting.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
                    break;

                case (_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleWipe):
                    btn_wipe.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
                    break;
            }
        }

        private void TransitionStyleChanged()
        {
            _BMDSwitcherTransitionStyle TransitionStyle;

            Transition.GetTransitionStyle(out TransitionStyle);


            btn_dip.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_mix.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_DVE.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_sting.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            btn_wipe.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));

            switch (TransitionStyle)
            {
                case (_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleDip):
                    btn_dip.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
                    break;

                case (_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleDVE):
                    btn_DVE.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
                    break;

                case (_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleMix):
                    btn_mix.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
                    break;

                case (_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleStinger):
                    btn_sting.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
                    break;

                case (_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleWipe):
                    btn_wipe.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
                    break;
            }
        }

        private void DKeyerClipChanged()
        {
        }

        private void DKeyerFramesRemainingChanged()
        {
            uint DKey1Frames;
            uint DKey2Frames;

            Me1_DKey1.GetFramesRemaining(out DKey1Frames);
            Me1_DKey1.GetFramesRemaining(out DKey2Frames);

            tb_DKey1Rate.Text = DKey1Frames.ToString();
            tb_DKey2Rate.Text = DKey2Frames.ToString();
        }

        private void DKeyerGainChanged()
        {
        }

        private void DKeyerInputCutChanged()
        {
        }

        private void DKeyerFillChanged()
        {
        }

        private void DKeyerInverseChanged()
        {
        }

        private void DKeyerIsAutoTransitioningChanged()
        {
            int DKey1IsAutoTransitioning;
            int DKey2IsAutoTransitioning;

            Me1_DKey1.IsAutoTransitioning(out DKey1IsAutoTransitioning);
            Me1_DKey2.IsAutoTransitioning(out DKey2IsAutoTransitioning);

            if (DKey1IsAutoTransitioning == 0)
            {
                btn_me1_dkey1auto.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            }
            else 
            {
                btn_me1_dkey1auto.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
            }

            if (DKey2IsAutoTransitioning == 0)
            {
                btn_me1_dkey2auto.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            }
            else
            {
                btn_me1_dkey2auto.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonred));
            }
        }

        private void DKeyerInputFillChanged()
        {
        }

        private void DKeyerIsTransitioningChanged()
        {
        }

        private void DKeyerMaskBottomChanged()
        {
        }

        private void DKeyerMaskedChanged()
        {
        }

        private void DKeyerMaskLeftChanged()
        {
        }

        private void DKeyerMaskRightChanged()
        {
        }

        private void DKeyerMaskTopChanged()
        {
        }

        private void DKeyerOnAirChanged()
        {
            int DKey1OnAir;
            int DKey2OnAir;

            Me1_DKey1.GetOnAir(out DKey1OnAir);
            Me1_DKey2.GetOnAir(out DKey2OnAir);

            if (DKey1OnAir == 0)
            {
                btn_me1_dkey1air.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            }
            else
            {
                btn_me1_dkey1air.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
            }

            if (DKey2OnAir == 0)
            {
                btn_me1_dkey2air.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            }
            else
            {
                btn_me1_dkey2air.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
            }
        }

        private void DKeyerPreMultipliedChanged()
        {
        }

        private void DKeyerRateChanged()
        {
            uint DKey1Rate;
            uint DKey2Rate;

            Me1_DKey1.GetRate(out DKey1Rate);
            Me1_DKey2.GetRate(out DKey2Rate);

            tb_DKey1Rate.Text = DKey1Rate.ToString();
            tb_DKey2Rate.Text = DKey2Rate.ToString();
        }

        private void DKeyerTieChanged()
        {
            int DKey1Tie;
            int DKey2Tie;

            Me1_DKey1.GetTie(out DKey1Tie);
            Me1_DKey2.GetTie(out DKey2Tie);

            if (DKey1Tie == 0)
            {
                btn_me1_dkey1tie.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            }
            else
            {
                btn_me1_dkey1tie.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
            }

            if (DKey2Tie == 0)
            {
                btn_me1_dkey2tie.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttongrey));
            }
            else
            {
                btn_me1_dkey2tie.BackgroundImage = ((System.Drawing.Image)(BMDGLC.Properties.Resources.buttonyellow));
            }
        }

        private void MultiviewLayoutChanged()
        {
        }

        private void MultiviewWindowChanged()
        {
        }

        private void BMInterface_Load(object sender, EventArgs e)
        {
            ConnectToSwitcher();
        }

        private void ConnectToSwitcher()
        {
             _BMDSwitcherConnectToFailure failReason = 0;
            string address = "192.168.1.100";

            try
            {
                // Note that ConnectTo() can take several seconds to return, both for success or failure,
                // depending upon hostname resolution and network response times, so it may be best to
                // do this in a separate thread to prevent the main GUI thread blocking.
                SwitcherDiscovery.ConnectTo(address, out Switcher, out failReason);
            }
            catch (COMException)
            {
                // An exception will be thrown if ConnectTo fails. For more information, see failReason.
                switch (failReason)
                {
                    case _BMDSwitcherConnectToFailure.bmdSwitcherConnectToFailureNoResponse:
                        MessageBox.Show("No response from Switcher", "Error");
                        break;
                    case _BMDSwitcherConnectToFailure.bmdSwitcherConnectToFailureIncompatibleFirmware:
                        MessageBox.Show("Switcher has incompatible firmware", "Error");
                        break;
                    default:
                        MessageBox.Show("Connection failed for unknown reason", "Error");
                        break;
                }
                return;
            }
            SwitcherConnected();
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
                    AUX1.AddCallback(InputAuxMonitor);
                    AUX2.AddCallback(InputAuxMonitor);
                    AUX3.AddCallback(InputAuxMonitor);
                    Color1.AddCallback(InputColorMonitor);
                    Color2.AddCallback(InputColorMonitor);
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

            Transition = (BMDSwitcherAPI.IBMDSwitcherTransitionParameters)MixEffectBlock1;
            Transition.AddCallback(TransitionMonitor);

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
            Me1_Key1.AddCallback(KeyMonitor);
            Me1_Key2.AddCallback(KeyMonitor);
            Me1_Key3.AddCallback(KeyMonitor);
            Me1_Key4.AddCallback(KeyMonitor);

            IBMDSwitcherDownstreamKeyIterator DKeyIterator;
            SwitcherAPIHelper.CreateIterator(MixEffectBlock1, out DKeyIterator);

            if (DKeyIterator != null)
            {
                DKeyIterator.Next(out Me1_DKey1);
                DKeyIterator.Next(out Me1_DKey2);
            }

            if (Me1_DKey1 == null || Me1_DKey2 == null)
            {
                MessageBox.Show("Unexpected: Could not get one of the DownstreamKeyers.", "Error");
                return;
            }

            Me1_DKey1.AddCallback(DownStreamKeyMonitor);
            Me1_DKey2.AddCallback(DownStreamKeyMonitor);

            IBMDSwitcherMediaPlayerIterator MediaPlayerIterator;
            SwitcherAPIHelper.CreateIterator(Switcher, out MediaPlayerIterator);

            if (MediaPlayerIterator != null)
            {
                MediaPlayerIterator.Next(out MediaPlayer1);
                MediaPlayerIterator.Next(out MediaPlayer2);
            }

            if (MediaPlayer1 == null || MediaPlayer2 == null)
            {
                MessageBox.Show("Unexpected: Could not get one of the MediaPlayers.", "Error");
                return;
            }

            DKeyerRateChanged();
            DKeyerTieChanged();
            DKeyerOnAirChanged();
            DKeyerIsTransitioningChanged();
            DKeyerIsAutoTransitioningChanged();
            TransitionStyleChanged();
            NextTransitionStyleChanged();
            KeyerOnAirChanged();
            InputAuxChanged();
            PreviewInputChanged();
            ProgramInputChanged();
            PreviewTransitionChanged();
            InTransitionChanged();
            TransitionFramesRemainingChanged();
            TransitionPositionChanged();
            InFadeToBlackChanged();
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

            if (AUX1 != null)
            {
                // Remove callback
                AUX1.RemoveCallback(InputAuxMonitor);

                // Release reference
                AUX1 = null;
            }

            if (AUX2 != null)
            {
                // Remove callback
                AUX2.RemoveCallback(InputAuxMonitor);

                // Release reference
                AUX2 = null;
            }

            if (AUX3 != null)
            {
                // Remove callback
                AUX3.RemoveCallback(InputAuxMonitor);

                // Release reference
                AUX3 = null;
            }

            if (Me1_DKey1 != null)
            {
                // Remove callback
                Me1_DKey1.RemoveCallback(DownStreamKeyMonitor);

                // Release reference
                Me1_DKey1 = null;
            }

            if (Me1_Key2 != null)
            {
                // Remove callback
                Me1_DKey2.RemoveCallback(DownStreamKeyMonitor);

                // Release reference
                Me1_DKey2 = null;
            }

            if (Me1_Key1 != null)
            {
                // Remove callback
                Me1_Key1.RemoveCallback(KeyMonitor);

                // Release reference
                Me1_Key1 = null;
            }

            if (Me1_Key2 != null)
            {
                // Remove callback
                Me1_Key2.RemoveCallback(KeyMonitor);

                // Release reference
                Me1_Key2 = null;
            }

            if (Me1_Key3 != null)
            {
                // Remove callback
                Me1_Key3.RemoveCallback(KeyMonitor);

                // Release reference
                Me1_Key3 = null;
            }

            if (Me1_Key4 != null)
            {
                // Remove callback
                Me1_Key4.RemoveCallback(KeyMonitor);

                // Release reference
                Me1_Key4 = null;
            }

            if (Color1 != null)
            {
                // Remove callback
                Color1.RemoveCallback(InputColorMonitor);

                // Release reference
                Color1 = null;
            }

            if (Color2 != null)
            {
                // Remove callback
                Color2.RemoveCallback(InputColorMonitor);

                // Release reference
                Color2 = null;
            }

            if (Switcher != null)
            {
                // Remove callback:
                Switcher.RemoveCallback(SwitcherMonitor);

                // release reference:
                Switcher = null;
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

        private void btn_blackprog_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput, 0);
        }

        private void btn_hdmi1prog_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput, 1);
        }

        private void btn_hdmi2prog_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput, 2);
        }

        private void btn_hdmi3prog_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput, 3);
        }

        private void btn_hdmi4prog_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput, 4);
        }

        private void btn_camera1prog_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput, 5);
        }

        private void btn_camera2prog_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput, 6);
        }

        private void btn_camera3prog_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput, 7);
        }

        private void btn_camera4prog_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput, 8);
        }

        private void btn_barsprog_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput, 9);
        }

        private void btn_color1prog_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput, 10);
        }

        private void btn_color2prog_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput, 11);
        }

        private void btn_media1prog_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput, 12);
        }

        private void btn_media2prog_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdProgramInput, 14);
        }

        private void btn_blackprew_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput, 0);
        }

        private void btn_hdmi1prew_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput, 1);
        }

        private void btn_hdmi2prew_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput, 2);
        }

        private void btn_hdmi3prew_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput, 3);
        }

        private void btn_hdmi4prew_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput, 4);
        }

        private void btn_camera1prew_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput, 5);
        }

        private void btn_camera2prew_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput, 6);
        }

        private void btn_camera3prew_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput, 7);
        }

        private void btn_camera4prew_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput, 8);
        }

        private void btn_barsprew_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput, 9);
        }

        private void btn_color1prew_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput, 10);
        }

        private void btn_color2prew_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput, 11);
        }

        private void btn_media1prew_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput, 12);
        }

        private void btn_media2prew_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewInput, 14);
        }

        private void btn_prevtrans_Click(object sender, EventArgs e)
        {
            long PreviewTransition;

            MixEffectBlock1.GetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewTransition, out PreviewTransition);

            if (PreviewTransition == 0)
            {
                MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewTransition, 1);
            }
            else
            {
                MixEffectBlock1.SetInt(_BMDSwitcherMixEffectBlockPropertyId.bmdSwitcherMixEffectBlockPropertyIdPreviewTransition, 0);
            }
        }

        private void btn_mix_Click(object sender, EventArgs e)
        {
            Transition.SetNextTransitionStyle(_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleMix);
        }

        private void btn_dip_Click(object sender, EventArgs e)
        {
            Transition.SetNextTransitionStyle(_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleDip);
        }

        private void btn_wipe_Click(object sender, EventArgs e)
        {
            Transition.SetNextTransitionStyle(_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleWipe);
        }

        private void btn_DVE_Click(object sender, EventArgs e)
        {
            Transition.SetNextTransitionStyle(_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleDVE);
        }

        private void btn_sting_Click(object sender, EventArgs e)
        {
            Transition.SetNextTransitionStyle(_BMDSwitcherTransitionStyle.bmdSwitcherTransitionStyleStinger);
        }

        private void btn_autotrans_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.PerformAutoTransition();
        }

        private void btn_cuttrans_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.PerformCut();
        }

        private void btn_FTB_Click(object sender, EventArgs e)
        {
            MixEffectBlock1.PerformFadeToBlack();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SwitcherDisconnected();
            this.Close();
        }

        private void reconnectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConnectToSwitcher();
        }

        private void btn_me1_dkey1auto_Click(object sender, EventArgs e)
        {
            Me1_DKey1.PerformAutoTransition();
        }

        private void btn_me1_dkey2auto_Click(object sender, EventArgs e)
        {
            Me1_DKey2.PerformAutoTransition();
        }

        private void btn_me1_dkey1air_Click(object sender, EventArgs e)
        {
            int DKey1OnAir;

            Me1_DKey1.GetOnAir(out DKey1OnAir);

            if (DKey1OnAir == 1)
            {
                Me1_DKey1.SetOnAir(0);
            }
            else
            {
                Me1_DKey1.SetOnAir(1);
            }
        }

        private void btn_me1_dkey2air_Click(object sender, EventArgs e)
        {
            int DKey2OnAir;

            Me1_DKey2.GetOnAir(out DKey2OnAir);

            if (DKey2OnAir == 1)
            {
                Me1_DKey2.SetOnAir(0);
            }
            else
            {
                Me1_DKey2.SetOnAir(1);
            }
        }

        private void btn_me1_dkey1tie_Click(object sender, EventArgs e)
        {
            int DKey1Tie;

            Me1_DKey1.GetTie(out DKey1Tie);

            if (DKey1Tie == 0)
            {
                Me1_DKey1.SetTie(1);
            }
            else
            {
                Me1_DKey1.SetTie(0);
            }
        }

        private void btn_me1_dkey2tie_Click(object sender, EventArgs e)
        {
            int DKey2Tie;

            Me1_DKey2.GetTie(out DKey2Tie);

            if (DKey2Tie == 0)
            {
                Me1_DKey2.SetTie(1);
            }
            else
            {
                Me1_DKey2.SetTie(0);
            }
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(0);
        }

        private void hDMI1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(1);
        }

        private void hDMI2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(2);
        }

        private void hDMI3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(3);
        }

        private void hDMI4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(4);
        }

        private void camera1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(5);
        }

        private void camera2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(6);
        }

        private void camera3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(7);
        }

        private void camera4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(8);
        }

        private void colorBarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(9);
        }

        private void color1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(10);
        }

        private void color2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(11);
        }

        private void mediaPlayer1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(12);
        }

        private void mediaPlayer1KeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(13);
        }

        private void mediaPlayer2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(14);
        }

        private void mediaPlayer2KeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(15);
        }

        private void programToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(16);
        }

        private void previewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(17);
        }

        private void cleanFeed1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(18);
        }

        private void cleanFeed2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AUX1.SetInputSource(19);
        }

        private void blackToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(0);
        }

        private void hDMI1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(1);
        }

        private void hDMI2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(2);
        }

        private void hDMI3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(3);
        }

        private void hDMI4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(4);
        }

        private void camera1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(5);
        }

        private void camera2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(6);
        }

        private void camera3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(7);
        }

        private void camera4ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(8);
        }

        private void colorBarsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(9);
        }

        private void color1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(10);
        }

        private void color2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(11);
        }

        private void mediaPlayer1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(12);
        }

        private void mediaPlayer1KeyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(13);
        }

        private void mediaPlayer2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(14);
        }

        private void mediaPlayer2KeyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(15);
        }

        private void programToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(16);
        }

        private void previewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(17);
        }

        private void cleanFeed1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(18);
        }

        private void cleanFeed2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AUX2.SetInputSource(19);
        }

        private void blackToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(0);
        }

        private void hDMI1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(1);
        }

        private void hDMI2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(2);
        }

        private void hDMI3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(3);
        }

        private void hDMI4ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(4);
        }

        private void camera1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(5);
        }

        private void camera2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(6);
        }

        private void camera3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(7);
        }

        private void camera4ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(8);
        }

        private void colorBarsToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(9);
        }

        private void color1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(10);
        }

        private void color2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(11);
        }

        private void mediaPlayer1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(12);
        }

        private void mediaPlayer1KeyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(13);
        }

        private void mediaPlayer2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(14);
        }

        private void mediaPlayer2KeyToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(15);
        }

        private void programToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(16);
        }

        private void previewToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(17);
        }

        private void cleanFeed1ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(18);
        }

        private void cleanFeed2ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AUX3.SetInputSource(19);
        }

        private void btn_editor_Click(object sender, EventArgs e)
        {
            Editor Editor = new Editor();
            Editor.Show();
        }
    }
}
