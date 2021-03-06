﻿using SFB;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConfigurationScript : MonoBehaviour
{
    private GameObject pnlImages;
    private GameObject pnlPredict;
    private GameObject pnlRecord;
    private GameObject pnlOthers;

    private Toggle ShowSource;
    private Toggle ShowInput;
    private Toggle SkipOnDrop;
    private Toggle RepeatPlayback;
    private Toggle MirrorUseCamera;
    private InputField ifSourceCutScale;
    private InputField ifSourceCutX;
    private InputField ifSourceCutY;

    private Toggle ShowBackground;
    private InputField ifBackgroundFile;
    private InputField ifBackgroundScale;
    private InputField ifBackgroundR;
    private InputField ifBackgroundG;
    private InputField ifBackgroundB;

    private InputField ifLowPassFilter;
    private InputField ifNOrderLPF;
    private InputField ifBWBuffer;
    private InputField ifBWCutoff;
    private InputField ifForwardThreshold;
    private InputField ifBackwardThreshold;
    private Toggle LockFoot;
    private Toggle LockLegs;
    private InputField ifHeightRatioThreshold;
    private Dropdown trainedModel;

    private InputField ifShoulderRattlingCheckFrame;
    private InputField ifThighRattlingCheckFrame;
    private InputField ifFootRattlingCheckFrame;
    private InputField ifArmRattlingCheckFrame;
    private InputField ifShinThreshold;
    private InputField ifShinSmooth;
    private InputField ifShinRatio;
    private InputField ifArmThreshold;
    private InputField ifArmSmooth;
    private InputField ifArmRatio;
    private InputField ifOtherThreshold;
    private InputField ifOtherSmooth;
    private InputField ifOtherRatio;

    private Toggle Blender;
    private Toggle EnforceHumanoidBones;
    private Toggle Capturing;
    private InputField ifCapturingFPS;
    private Toggle CatchUp;

    private Toggle UseUnityCapture;
    private Toggle UseVMCProtocol;
    private InputField ifVMCPIP;
    private InputField ifVMCPPort;
    private Toggle VMCPRot;


    private UIScript currentUI;
    private ConfigurationSetting configurationSetting;


    public void Init()
    {
        pnlImages = GameObject.Find("pnlImages");
        pnlPredict = GameObject.Find("pnlPredict");
        pnlRecord = GameObject.Find("pnlRecord");
        pnlOthers = GameObject.Find("pnlOthers");

        pnlImages.SetActive(true);
        pnlPredict.SetActive(true);
        pnlRecord.SetActive(true);
        pnlOthers.SetActive(true);

        ShowSource = GameObject.Find("ShowSource").GetComponent<Toggle>();
        ShowInput = GameObject.Find("ShowInput").GetComponent<Toggle>();
        SkipOnDrop = GameObject.Find("SkipOnDrop").GetComponent<Toggle>();
        RepeatPlayback = GameObject.Find("RepeatPlayback").GetComponent<Toggle>();
        MirrorUseCamera = GameObject.Find("MirrorUseCamera").GetComponent<Toggle>();
        ifSourceCutScale = GameObject.Find("ifSourceCutScale").GetComponent<InputField>();
        ifSourceCutX = GameObject.Find("ifSourceCutX").GetComponent<InputField>();
        ifSourceCutY = GameObject.Find("ifSourceCutY").GetComponent<InputField>();

        ShowBackground = GameObject.Find("ShowBackground").GetComponent<Toggle>();
        ifBackgroundFile = GameObject.Find("ifBackgroundFile").GetComponent<InputField>();
        ifBackgroundScale = GameObject.Find("ifBackgroundScale").GetComponent<InputField>();
        ifBackgroundR = GameObject.Find("ifBackgroundR").GetComponent<InputField>();
        ifBackgroundG = GameObject.Find("ifBackgroundG").GetComponent<InputField>();
        ifBackgroundB = GameObject.Find("ifBackgroundB").GetComponent<InputField>();

        ifLowPassFilter = GameObject.Find("ifLowPassFilter").GetComponent<InputField>();
        ifNOrderLPF = GameObject.Find("ifNOrderLPF").GetComponent<InputField>();
        ifBWBuffer = GameObject.Find("ifBWBuffer").GetComponent<InputField>();
        ifBWCutoff = GameObject.Find("ifBWCutoff").GetComponent<InputField>();
        ifForwardThreshold = GameObject.Find("ifForwardThreshold").GetComponent<InputField>();
        ifBackwardThreshold = GameObject.Find("ifBackwardThreshold").GetComponent<InputField>();
        LockFoot = GameObject.Find("LockFoot").GetComponent<Toggle>();
        LockLegs = GameObject.Find("LockLegs").GetComponent<Toggle>();
        ifHeightRatioThreshold = GameObject.Find("ifHeightRatioThreshold").GetComponent<InputField>();
        trainedModel = GameObject.Find("TrainedModel").GetComponent<Dropdown>();

        ifShoulderRattlingCheckFrame = GameObject.Find("ifShoulderRattlingCheckFrame").GetComponent<InputField>();
        ifThighRattlingCheckFrame = GameObject.Find("ifThighRattlingCheckFrame").GetComponent<InputField>();
        ifFootRattlingCheckFrame = GameObject.Find("ifFootRattlingCheckFrame").GetComponent<InputField>();
        ifArmRattlingCheckFrame = GameObject.Find("ifArmRattlingCheckFrame").GetComponent<InputField>();
        ifShinThreshold = GameObject.Find("ifShinThreshold").GetComponent<InputField>();
        ifShinSmooth = GameObject.Find("ifShinSmooth").GetComponent<InputField>();
        ifShinRatio = GameObject.Find("ifShinRatio").GetComponent<InputField>();
        ifArmThreshold = GameObject.Find("ifArmThreshold").GetComponent<InputField>();
        ifArmSmooth = GameObject.Find("ifArmSmooth").GetComponent<InputField>();
        ifArmRatio = GameObject.Find("ifArmRatio").GetComponent<InputField>();
        ifOtherThreshold = GameObject.Find("ifOtherThreshold").GetComponent<InputField>();
        ifOtherSmooth = GameObject.Find("ifOtherSmooth").GetComponent<InputField>();
        ifOtherRatio = GameObject.Find("ifOtherRatio").GetComponent<InputField>();

        Blender = GameObject.Find("Blender").GetComponent<Toggle>();
        EnforceHumanoidBones = GameObject.Find("EnforceHumanoidBones").GetComponent<Toggle>();
        Capturing = GameObject.Find("Capturing").GetComponent<Toggle>();
        ifCapturingFPS = GameObject.Find("ifCapturingFPS").GetComponent<InputField>();
        CatchUp = GameObject.Find("CatchUp").GetComponent<Toggle>();

        UseUnityCapture = GameObject.Find("UseUnityCapture").GetComponent<Toggle>();
        UseVMCProtocol = GameObject.Find("UseVMCProtocol").GetComponent<Toggle>();
        ifVMCPIP = GameObject.Find("ifVMCPIP").GetComponent<InputField>();
        ifVMCPPort = GameObject.Find("ifVMCPPort").GetComponent<InputField>();
        VMCPRot = GameObject.Find("VMCPRot").GetComponent<Toggle>();

        pnlImages.SetActive(true);
        pnlPredict.SetActive(false);
        pnlRecord.SetActive(false);
        pnlOthers.SetActive(false);
    }

    public void ShowSetting(ConfigurationSetting config)
    {
        configurationSetting = config;

        ShowSource.isOn = config.ShowSource == 1;
        ShowInput.isOn = config.ShowInput == 1;
        SkipOnDrop.isOn = config.SkipOnDrop == 1;
        RepeatPlayback.isOn = config.RepeatPlayback == 1;
        MirrorUseCamera.isOn = config.MirrorUseCamera == 1;

        ifSourceCutScale.text = config.SourceCutScale.ToString("0.00");
        ifSourceCutX.text = config.SourceCutX.ToString("0.00");
        ifSourceCutY.text = config.SourceCutY.ToString("0.00");

        ShowBackground.isOn = config.ShowBackground == 1;
        ifBackgroundFile.text = config.BackgroundFile;
        ifBackgroundScale.text = config.BackgroundScale.ToString("0.00");
        ifBackgroundR.text = config.BackgroundR.ToString("0");
        ifBackgroundG.text = config.BackgroundG.ToString("0");
        ifBackgroundB.text = config.BackgroundB.ToString("0");

        ifLowPassFilter.text = config.LowPassFilter.ToString("0.00");
        ifNOrderLPF.text = config.NOrderLPF.ToString();
        ifBWBuffer.text = config.BWBuffer.ToString();
        ifBWCutoff.text = config.BWCutoff.ToString("0.00");
        ifForwardThreshold.text = config.ForwardThreshold.ToString("0.00");
        ifBackwardThreshold.text = config.BackwardThreshold.ToString("0.00");
        LockFoot.isOn = config.LockFoot == 1;
        LockLegs.isOn = config.LockLegs == 1;
        ifHeightRatioThreshold.text = config.HeightRatioThreshold.ToString("0.00");
        trainedModel.value = config.TrainedModel;

        ifShoulderRattlingCheckFrame.text = config.ShoulderRattlingCheckFrame.ToString();
        ifThighRattlingCheckFrame.text = config.ThighRattlingCheckFrame.ToString();
        ifFootRattlingCheckFrame.text = config.FootRattlingCheckFrame.ToString();
        ifArmRattlingCheckFrame.text = config.ArmRattlingCheckFrame.ToString();
        ifShinThreshold.text = config.ShinThreshold.ToString("0.00");
        ifShinSmooth.text = config.ShinSmooth.ToString("0.00");
        ifShinRatio.text = config.ShinRatio.ToString("0.00");
        ifArmThreshold.text = config.ArmThreshold.ToString("0.00");
        ifArmSmooth.text = config.ArmSmooth.ToString("0.00");
        ifArmRatio.text = config.ArmRatio.ToString("0.00");
        ifOtherThreshold.text = config.OtherThreshold.ToString("0.00");
        ifOtherSmooth.text = config.OtherSmooth.ToString("0.00");
        ifOtherRatio.text = config.OtherRatio.ToString("0.00");

        Blender.isOn = config.Blender == 1;
        EnforceHumanoidBones.isOn = config.EnforceHumanoidBones == 1;
        Capturing.isOn = config.Capturing == 1;
        ifCapturingFPS.text = config.CapturingFPS.ToString("0");
        CatchUp.isOn = config.CatchUp == 1;

        UseUnityCapture.isOn = config.UseUnityCapture == 1;
        UseVMCProtocol.isOn = config.UseVMCProtocol == 1;
        ifVMCPIP.text = config.VMCPIP;
        ifVMCPPort.text = config.VMCPPort.ToString("0"); ;
        VMCPRot.isOn = config.VMCPRot == 1;
    }

    public void Show(UIScript ui, ConfigurationSetting config)
    {
        currentUI = ui;
        ShowSetting(config);

        this.gameObject.SetActive(true);
    }

    public void Close()
    {
        this.gameObject.SetActive(false);
    }

    private string SetSetting()
    {
        var f = 0f;

        configurationSetting.ShowSource = ShowSource.isOn ? 1 : 0;
        configurationSetting.ShowInput = ShowInput.isOn ? 1 : 0;
        configurationSetting.SkipOnDrop = SkipOnDrop.isOn ? 1 : 0;
        configurationSetting.RepeatPlayback = RepeatPlayback.isOn ? 1 : 0;
        configurationSetting.MirrorUseCamera = MirrorUseCamera.isOn ? 1 : 0;

        if (!float.TryParse(ifSourceCutScale.text, out configurationSetting.SourceCutScale))
        {
            return "Source Cut Scale is required.";
        }
        if (!float.TryParse(ifSourceCutX.text, out configurationSetting.SourceCutX))
        {
            return "Source Cut Center position X is required.";
        }
        if (!float.TryParse(ifSourceCutY.text, out configurationSetting.SourceCutY))
        {
            return "Source Cut Center position Y is required.";
        }

        configurationSetting.ShowBackground = ShowBackground.isOn ? 1 : 0;
        configurationSetting.BackgroundFile = ifBackgroundFile.text.Trim();
        if (!float.TryParse(ifBackgroundScale.text, out configurationSetting.BackgroundScale))
        {
            return "Background Scale is required.";
        }
        var i = 0;
        if (!int.TryParse(ifBackgroundR.text, out i))
        {
            return "Background Color R is required.";
        }
        if (i < 0 || i > 255)
        {
            return "Background Color R is between 0 and 255";
        }
        configurationSetting.BackgroundR = i;
        if (!int.TryParse(ifBackgroundG.text, out i))
        {
            return "Background Color G is required.";
        }
        if (i < 0 || i > 255)
        {
            return "Background Color G is between 0 and 255";
        }
        configurationSetting.BackgroundG = i;
        if (!int.TryParse(ifBackgroundB.text, out i))
        {
            return "Background Color B is required.";
        }
        if (i < 0 || i > 255)
        {
            return "Background Color B is between 0 and 255";
        }
        configurationSetting.BackgroundB = i;

        if (!float.TryParse(ifLowPassFilter.text, out f))
        {
            return "Low Pass Filter is required.";
        }
        if (f < 0f || f > 1f)
        {
            return "Low Pass Filter is between 0 and 1.";
        }
        configurationSetting.LowPassFilter = f;

        if (!int.TryParse(ifNOrderLPF.text, out i))
        {
            return "N-Order LPF is required.";
        }
        if (i < 1 || i >= 10)
        {
            return "N-Order LPF is between 1 and 10.";
        }
        configurationSetting.NOrderLPF = i;

        if (!int.TryParse(ifBWBuffer.text, out i))
        {
            return "BW Buffer is required.";
        }
        if (i < 100 || i >= 10000)
        {
            return "BW Buffer is between 100 and 10000.";
        }
        configurationSetting.BWBuffer = i;

        if (!float.TryParse(ifBWCutoff.text, out f))
        {
            return "BW Cutoff is required.";
        }
        if (f < 0f || f > 100f)
        {
            return "BW Cutoff is between 0 and 100.";
        }
        configurationSetting.BWCutoff = f;

        if (!float.TryParse(ifForwardThreshold.text, out f))
        {
            return "Forward Threshold is required.";
        }
        if (f < 0f || f > 1f)
        {
            return "Forward Threshold is between 0 and 1.";
        }
        configurationSetting.ForwardThreshold = f;

        if (!float.TryParse(ifBackwardThreshold.text, out f))
        {
            return "Backward Threshold is required.";
        }
        if (f < 0f || f > 1f)
        {
            return "Backward Threshold is between 0 and 1.";
        }
        configurationSetting.BackwardThreshold = f;

        configurationSetting.LockFoot = LockFoot.isOn ? 1 : 0;
        configurationSetting.LockLegs = LockLegs.isOn ? 1 : 0;

        if (!float.TryParse(ifHeightRatioThreshold.text, out f))
        {
            return "Height Ratio Threshold is required.";
        }
        if (f < 0f || f > 100f)
        {
            return "Height Ratio Threshold is between 0 and 100.";
        }
        configurationSetting.HeightRatioThreshold = f;

        configurationSetting.TrainedModel = trainedModel.value;

        if (!int.TryParse(ifShoulderRattlingCheckFrame.text, out i))
        {
            return "Shoulder Rattling Check Frame is required.";
        }
        if (i < 0 || i >= 30)
        {
            return "Shoulder Rattling Check Frame is between 0 and 30.";
        }
        configurationSetting.ShoulderRattlingCheckFrame = i;

        if (!int.TryParse(ifThighRattlingCheckFrame.text, out i))
        {
            return "Thigh Rattling Check Frame is required.";
        }
        if (i < 0 || i >= 30)
        {
            return "Thigh Rattling Check Frame is between 0 and 30.";
        }
        configurationSetting.ThighRattlingCheckFrame = i;

        if (!int.TryParse(ifFootRattlingCheckFrame.text, out i))
        {
            return "Foot Rattling Check Frame is required.";
        }
        if (i < 0 || i >= 30)
        {
            return "Foot Rattling Check Frame is between 0 and 30.";
        }
        configurationSetting.FootRattlingCheckFrame = i;

        if (!int.TryParse(ifArmRattlingCheckFrame.text, out i))
        {
            return "Arm Rattling Check Frame is required.";
        }
        if (i < 0 || i >= 30)
        {
            return "Arm Rattling Check Frame is between 0 and 30.";
        }
        configurationSetting.ArmRattlingCheckFrame = i;

        if (!float.TryParse(ifShinThreshold.text, out f))
        {
            return "Shin Threshold is required.";
        }
        if (f < 0f || f > 1f)
        {
            return "Shin Threshold is between 0 and 1.";
        }
        configurationSetting.ShinThreshold = f;

        if (!float.TryParse(ifShinSmooth.text, out f))
        {
            return "Shin Smooth is required.";
        }
        if (f < 0f || f > 1f)
        {
            return "Shin Smooth is between 0 and 1.";
        }
        configurationSetting.ShinSmooth = f;

        if (!float.TryParse(ifShinRatio.text, out f))
        {
            return "Shin Ratio is required.";
        }
        if (f < 0f || f > 10f)
        {
            return "Shin Ratio is between 0 and 10.";
        }
        configurationSetting.ShinRatio = f;

        if (!float.TryParse(ifArmThreshold.text, out f))
        {
            return "Arm Threshold is required.";
        }
        if (f < 0f || f > 1f)
        {
            return "Arm Threshold is between 0 and 1.";
        }
        configurationSetting.ArmThreshold = f;

        if (!float.TryParse(ifArmSmooth.text, out f))
        {
            return "Arm Smooth is required.";
        }
        if (f < 0f || f > 1f)
        {
            return "Arm Smooth is between 0 and 1.";
        }
        configurationSetting.ArmSmooth = f;

        if (!float.TryParse(ifArmRatio.text, out f))
        {
            return "Arm Ratio is required.";
        }
        if (f < 0f || f > 10f)
        {
            return "Arm Ratio is between 0 and 10.";
        }
        configurationSetting.ArmRatio = f;


        if (!float.TryParse(ifOtherThreshold.text, out f))
        {
            return "Other Threshold is required.";
        }
        if (f < 0f || f > 1f)
        {
            return "Other Threshold is between 0 and 1.";
        }
        configurationSetting.OtherThreshold = f;

        if (!float.TryParse(ifOtherSmooth.text, out f))
        {
            return "Other Smooth is required.";
        }
        if (f < 0f || f > 1f)
        {
            return "Other Smooth is between 0 and 1.";
        }
        configurationSetting.OtherSmooth = f;

        if (!float.TryParse(ifOtherRatio.text, out f))
        {
            return "Other Ratio is required.";
        }
        if (f < 0f || f > 10f)
        {
            return "Other Ratio is between 0 and 10.";
        }
        configurationSetting.OtherRatio = f;

        configurationSetting.Blender = Blender.isOn ? 1 : 0;
        configurationSetting.EnforceHumanoidBones = EnforceHumanoidBones.isOn ? 1 : 0;
        configurationSetting.Capturing = Capturing.isOn ? 1 : 0;
        if (!float.TryParse(ifCapturingFPS.text, out f))
        {
            return "Capturing FPS is required.";
        }
        if (f < 0f || f > 120f)
        {
            return "Low Capturing FPS is between 0 and 120.";
        }
        configurationSetting.CapturingFPS = f;
        configurationSetting.CatchUp = CatchUp.isOn ? 1 : 0;

        configurationSetting.UseUnityCapture = UseUnityCapture.isOn ? 1 : 0;
        configurationSetting.UseVMCProtocol = UseVMCProtocol.isOn ? 1 : 0;
        configurationSetting.VMCPIP = ifVMCPIP.text.Trim();
        if (!int.TryParse(ifVMCPPort.text, out i))
        {
            return "Server IP is required.";
        }
        if (i < 0 || i > 100000)
        {
            return "Port num is between 0 and 100000";
        }
        configurationSetting.VMCPPort = i;
        configurationSetting.VMCPRot = VMCPRot.isOn ? 1 : 0;

        return "";
    }

    public void onOK()
    {
        var msg = SetSetting();
        if (msg != "")
        {
            currentUI.ShowMessage(msg);
        }
        else
        {
            currentUI.SetConfiguration(configurationSetting);
            Close();
        }
    }

    public void onApply()
    {
        var msg = SetSetting();
        if (msg != "")
        {
            currentUI.ShowMessage(msg);
        }
        else
        {
            currentUI.SetConfiguration(configurationSetting);
        }
    }

    public void onRestoreSettings()
    {
        currentUI.RestoreSettings();
    }

    public void onCancel()
    {
        Close();
    }

    public void onTabImages()
    {
        DeactivateTabPanel();
        pnlImages.SetActive(true);
    }

    public void onTabPredict()
    {
        DeactivateTabPanel();
        pnlPredict.SetActive(true);
    }

    public void onTabRecord()
    {
        DeactivateTabPanel();
        pnlRecord.SetActive(true);
    }

    public void onTabOthers()
    {
        DeactivateTabPanel();
        pnlOthers.SetActive(true);
    }

    private void DeactivateTabPanel()
    {
        if(pnlImages.activeSelf) pnlImages.SetActive(false);
        if (pnlPredict.activeSelf) pnlPredict.SetActive(false);
        if (pnlRecord.activeSelf) pnlRecord.SetActive(false);
        if (pnlOthers.activeSelf) pnlOthers.SetActive(false);
    }

    public void onOpenBrowser()
    {
        Application.OpenURL("https://digital-standard.com");
    }

    public void onBackgroundFile()
    {
        var extensions = new[]
        {
                new ExtensionFilter( "Image Files", "png", "jpg", "jpeg" ),
            };
        var paths = StandaloneFileBrowser.OpenFilePanel("Open File", "", extensions, false);

        if (paths.Length != 0)
        {
            ifBackgroundFile.text = paths[0];
        }
    }

    public void TrainedModel_Changed(int value)
    {
    }
}
