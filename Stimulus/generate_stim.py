from neuxus.nodes import *
#import audiostim

generated_data = generate.Generator(
    generator='simulation',
    nb_channels=16,
    sampling_frequency=125)

# dir_path is the path to directory containing this file
stim_cfg = dir_path + '/stimulations.xml'

# Node 1
generated_markers = stimulator.Stimulator(
    file=stim_cfg
)


graz = display.Graz(input_port=generated_markers.output)


#sound1 =  audiostim.StimulationBasedEpoching(generated_data.output, generated_markers.output, 786, 0.1, 0.1, '../beep-0.25-sec.wav')
