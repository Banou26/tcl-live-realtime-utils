import crypto from 'crypto'

import fetch from 'node-fetch'

const key = Buffer.from([
  14,
  227,
  73,
  7,
  212,
  206,
  76,
  182,
  250,
  182,
  108,
  241,
  142,
  146,
  187,
  66
])

fetch(
  'https://antilope-gp.ovh/Vehicules', {
    method: 'POST',
    headers: {
      'Content-Type': 'application/json',
      'Content-Length': 27
    },
    body: '{"Lignes":[],"Extent":null}'
  })
  .then(res => res.json())
  .then(({ IV: iv, CipherText: cipherText }) => {
    const ivBuffer = Buffer.from(iv, 'base64')
    const decipher = crypto.createDecipheriv('aes-128-cbc', key, ivBuffer)

    const corruptedVehicleLocationsJSON = 
      decipher.update(
        Buffer.from(cipherText, 'base64')
      )
      .toString()

    console.log(corruptedVehicleLocationsJSON)
  })