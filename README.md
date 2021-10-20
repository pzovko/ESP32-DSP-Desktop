# ESP-DSP-Desktop
[![Project Status: Active – The project has reached a stable, usable state and is being actively developed.](https://www.repostatus.org/badges/latest/active.svg)](https://www.repostatus.org/#active)

The ESP Digital Signal Processing desktop application is an open source project developed mainly for educational purposes. Filters can be designed and send to the device using Bluetooth. The raw signal and filtered signal can be compared and filtered frequencies can be seen using an FFT plot.

## Things to improve

- IIR filter support

  Main focus was on FIR filters, but IIR filters will be added too.

- Faster transfer rate
  
  Bluetooth has its bandwidth limitations, so when testing filters on high frequency signals the results have some latency. Other communication methods will be added.
